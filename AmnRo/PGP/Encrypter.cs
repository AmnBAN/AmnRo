using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmnRo.PGP
{
    class Encrypter
    {
        private EncryptionKeys m_encryptionKeys;

        private const int BufferSize = 0x10000; // should always be power of 2 

        /// <summary>

        /// Instantiate a new PgpEncrypt class with initialized PgpEncryptionKeys.

        /// </summary>

        /// <param name="encryptionKeys"></param>

        /// <exception cref="ArgumentNullException">encryptionKeys is null</exception>

        public Encrypter(EncryptionKeys encryptionKeys)
        {

            if (encryptionKeys == null)

                throw new ArgumentNullException("encryptionKeys", "encryptionKeys is null.");

            m_encryptionKeys = encryptionKeys;

        }

        /// <summary>

        /// Encrypt and the file pointed to by unencryptedFileInfo and

        /// write the encrypted content to outputStream.

        /// </summary>

        /// <param name="outputStream">The stream that will contain the

        /// encrypted data when this method returns.</param>

        /// <param name="fileName">FileInfo of the file to encrypt</param>

        public void Encrypt(Stream outputStream, FileInfo unencryptedFileInfo)
        {

            if (outputStream == null)

                throw new ArgumentNullException("outputStream", "outputStream is null.");

            if (unencryptedFileInfo == null)

                throw new ArgumentNullException("unencryptedFileInfo", "unencryptedFileInfo is null.");

            if (!File.Exists(unencryptedFileInfo.FullName))

                throw new ArgumentException("File to encrypt not found.");

            using (Stream encryptedOut = ChainEncryptedOut(outputStream))

            using (Stream compressedOut = ChainCompressedOut(encryptedOut))
            {

                //PgpSignatureGenerator signatureGenerator = InitSignatureGenerator(compressedOut);

                using (Stream literalOut = ChainLiteralOut(compressedOut, unencryptedFileInfo))

                using (FileStream inputFile = unencryptedFileInfo.OpenRead())
                {

                    WriteOutput(compressedOut, literalOut, inputFile);

                }

            }

        }


        /// <summary>

        /// Encrypt and sign the file pointed to by unencryptedFileInfo and

        /// write the encrypted content to outputStream.

        /// </summary>

        /// <param name="outputStream">The stream that will contain the

        /// encrypted data when this method returns.</param>

        /// <param name="fileName">FileInfo of the file to encrypt</param>

        public void EncryptAndSign(Stream outputStream, FileInfo unencryptedFileInfo)
        {

            if (outputStream == null)

                throw new ArgumentNullException("outputStream", "outputStream is null.");

            if (unencryptedFileInfo == null)

                throw new ArgumentNullException("unencryptedFileInfo", "unencryptedFileInfo is null.");

            if (!File.Exists(unencryptedFileInfo.FullName))

                throw new ArgumentException("File to encrypt not found.");

            using (Stream encryptedOut = ChainEncryptedOut(outputStream))

            using (Stream compressedOut = ChainCompressedOut(encryptedOut))
            {

                PgpSignatureGenerator signatureGenerator = InitSignatureGenerator(compressedOut);

                using (Stream literalOut = ChainLiteralOut(compressedOut, unencryptedFileInfo))

                using (FileStream inputFile = unencryptedFileInfo.OpenRead())
                {

                    WriteOutputAndSign(compressedOut, literalOut, inputFile, signatureGenerator);

                }

            }

        }

        private static void WriteOutput(Stream compressedOut, Stream literalOut, FileStream inputFile)
        {
            int length = 0;
            byte[] buf = new byte[BufferSize];

            while ((length = inputFile.Read(buf, 0, buf.Length)) > 0)
            {

                literalOut.Write(buf, 0, length);
            }
        }
        private static void WriteOutputAndSign(Stream compressedOut,

            Stream literalOut,

            FileStream inputFile,

            PgpSignatureGenerator signatureGenerator)
        {

            int length = 0;

            byte[] buf = new byte[BufferSize];

            while ((length = inputFile.Read(buf, 0, buf.Length)) > 0)
            {

                literalOut.Write(buf, 0, length);

                signatureGenerator.Update(buf, 0, length);

            }

            signatureGenerator.Generate().Encode(compressedOut);

        }

        private Stream ChainEncryptedOut(Stream outputStream)
        {

            PgpEncryptedDataGenerator encryptedDataGenerator;

            encryptedDataGenerator =

                new PgpEncryptedDataGenerator(SymmetricKeyAlgorithmTag.TripleDes,
                                              new SecureRandom());

            encryptedDataGenerator.AddMethod(m_encryptionKeys.PublicKey);

            return encryptedDataGenerator.Open(outputStream, new byte[BufferSize]);

        }

        private static Stream ChainCompressedOut(Stream encryptedOut)
        {

            PgpCompressedDataGenerator compressedDataGenerator =

                new PgpCompressedDataGenerator(CompressionAlgorithmTag.Zip);

            return compressedDataGenerator.Open(encryptedOut);

        }

        private static Stream ChainLiteralOut(Stream compressedOut, FileInfo file)
        {
            #region Fill Additional Data
            byte[] additionalDataBuffer = new byte[AdditionalBufferStructure.FullSize];
            string ext = file.Extension;
            string ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            byte[] extBytes = Encoding.GetEncoding("UTF-8").GetBytes(ext.ToCharArray()); // max:20
            byte[] verBytes = Encoding.GetEncoding("UTF-8").GetBytes(ver.ToCharArray()); // max:20

            for (int i = 0; i < extBytes.Length; i++)
                additionalDataBuffer[i] = extBytes[i];
            int verOffset = AdditionalBufferStructure.ExtensionSize;
            for (int i = verOffset; i < verOffset + verBytes.Length; i++)
                additionalDataBuffer[i] = verBytes[i - verOffset];

            #endregion


            PgpLiteralDataGenerator pgpLiteralDataGenerator = new PgpLiteralDataGenerator();

            var ldg = pgpLiteralDataGenerator.Open(compressedOut, PgpLiteralData.Binary, file.FullName , file.Length + additionalDataBuffer.Length , DateTime.Now);
          
            ldg.Write(additionalDataBuffer, 0 , additionalDataBuffer.Length);

            return ldg ;

        }

        private PgpSignatureGenerator InitSignatureGenerator(Stream compressedOut)
        {

            const bool IsCritical = false;

            const bool IsNested = false;

            PublicKeyAlgorithmTag tag = m_encryptionKeys.SecretKey.PublicKey.Algorithm;

            PgpSignatureGenerator pgpSignatureGenerator =

                new PgpSignatureGenerator(tag, HashAlgorithmTag.Sha1);

            pgpSignatureGenerator.InitSign(PgpSignature.BinaryDocument, m_encryptionKeys.PrivateKey);

            foreach (string userId in m_encryptionKeys.SecretKey.PublicKey.GetUserIds())
            {

                PgpSignatureSubpacketGenerator subPacketGenerator =
                   new PgpSignatureSubpacketGenerator();

                subPacketGenerator.SetSignerUserId(IsCritical, userId);

                pgpSignatureGenerator.SetHashedSubpackets(subPacketGenerator.Generate());

                // Just the first one!

                break;

            }

            pgpSignatureGenerator.GenerateOnePassVersion(IsNested).Encode(compressedOut);

            return pgpSignatureGenerator;

        }

    }

}

