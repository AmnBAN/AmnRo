using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.IO;
using System.Linq;

namespace AmnRo.PGP
{
    class Decrypter
    {
        private const int BufferSize = 0x10000; // should always be power of 2



        #region Decrypt

        /*
       * decrypt a given stream.
       */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputFileName"></param>
        /// <param name="keyFileName"></param> private key file path
        /// <param name="passwd"></param>
        /// <param name="outPath"></param>
        /// <param name="extractAdditionalData"></param>    using for old version of Amnro
        /// <returns>Tuple(Extentsion , Version)</returns>
        /// if (Extension == "") => file encrypted with old version of AmnRo
        public Tuple<string, string> DecryptFile(
            string inputFileName,
            string keyFileName,
            string passwd,
            string outPath,
            bool extractAdditionalData = true)
        {
            Stream outStream;
            Tuple<string, string> result;
            if (outPath == "")
            {
                outStream = new MemoryStream();
            }
            else
            {
                outStream = new FileStream(outPath, FileMode.Create);
            }
            using (Stream input = File.OpenRead(inputFileName) , keyIn = File.OpenRead(keyFileName) ){
                result = DecryptFile(input, keyIn, passwd.ToArray(), outStream , extractAdditionalData);
            }
            return result;

        }

        private Tuple<string, string> DecryptFile(
            Stream inputStream,
            Stream keyIn,
            char[] passwd,
            Stream outstream,
            bool extractAdditionalData)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            Tuple<string, string> result = new Tuple<string, string>("","");

            PgpObjectFactory pgpF = new PgpObjectFactory(inputStream);
            PgpEncryptedDataList enc;

            PgpObject o = pgpF.NextPgpObject();
            //
            // the first object might be a PGP marker packet.
            //
            if (o is PgpEncryptedDataList)
            {
                enc = (PgpEncryptedDataList)o;
            }
            else
            {
                enc = (PgpEncryptedDataList)pgpF.NextPgpObject();
            }

            //
            // find the secret key
            //
            PgpPrivateKey sKey = null;
            PgpPublicKeyEncryptedData pbe = null;
            PgpSecretKeyRingBundle pgpSec = new PgpSecretKeyRingBundle(
                PgpUtilities.GetDecoderStream(keyIn));

            foreach (PgpPublicKeyEncryptedData pked in enc.GetEncryptedDataObjects())
            {
                sKey = FindSecretKey(pgpSec, pked.KeyId, passwd);

                if (sKey != null)
                {
                    pbe = pked;
                    break;
                }
            }

            if (sKey == null)
            {
                throw new ArgumentException("secret key for message not found.");
            }

            Stream clear = pbe.GetDataStream(sKey);

            PgpObjectFactory plainFact = new PgpObjectFactory(clear);

            PgpObject message = plainFact.NextPgpObject();

            if (message is PgpCompressedData)
            {
                PgpCompressedData cData = (PgpCompressedData)message;
                PgpObjectFactory pgpFact = new PgpObjectFactory(cData.GetDataStream());

                message = pgpFact.NextPgpObject();
            }

            if (message is PgpLiteralData)
            {
                PgpLiteralData ld = (PgpLiteralData)message;

                Stream fOut = outstream;
                Stream unc = ld.GetInputStream();
                if (extractAdditionalData)
                    result = ExtractAdditionalData(unc);
                Streams.PipeAll(unc, fOut);
                fOut.Close();
            }
            else if (message is PgpOnePassSignatureList)
            {
                throw new PgpException("encrypted message contains a signed message - not literal data.");
            }
            else
            {
                throw new PgpException("message is not a simple encrypted file - type unknown.");
            }

            if (pbe.IsIntegrityProtected())
            {
                if (!pbe.Verify())
                {
                    Console.Error.WriteLine("message failed integrity check");
                }
                else
                {
                    Console.Error.WriteLine("message integrity check passed");
                }
            }
            else
            {
                Console.Error.WriteLine("no message integrity check");
            }
            
            return result;

        }


        private static Tuple<string, string> ExtractAdditionalData(Stream unc)
        {
            byte[] buffer = new byte[AdditionalBufferStructure.FullSize];
            unc.Read(buffer, 0, buffer.Length);
            var ver = System.Text.Encoding.UTF8.GetString(buffer.Take(AdditionalBufferStructure.VersionSize)
                .Where(e => e != '\0')
                .ToArray());
            var ext = System.Text.Encoding.UTF8.GetString(buffer.Skip(AdditionalBufferStructure.VersionSize)
                .Where(e => e != '\0')
                .ToArray());


            if (ver.Substring(0, 5) != "AmnRo")
            {
                ext = "";
            }

            return Tuple.Create(ext, ver);
        }
             
    
        #endregion Decrypt

        #region Private helpers

        /*
        * A simple routine that opens a key ring file and loads the first available key suitable for encryption.
        */

        private static PgpPublicKey ReadPublicKey(Stream inputStream)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);

            PgpPublicKeyRingBundle pgpPub = new PgpPublicKeyRingBundle(inputStream);

            // we just loop through the collection till we find a key suitable for encryption, in the real
            // world you would probably want to be a bit smarter about this.
            // iterate through the key rings.
            foreach (PgpPublicKeyRing kRing in pgpPub.GetKeyRings())
            {
                foreach (PgpPublicKey k in kRing.GetPublicKeys())
                {
                    if (k.IsEncryptionKey)
                        return k;
                }
            }

            throw new ArgumentException("Can't find encryption key in key ring.");
        }

        /*
        * Search a secret key ring collection for a secret key corresponding to keyId if it exists.
        */

        private static PgpPrivateKey FindSecretKey(PgpSecretKeyRingBundle pgpSec, long keyId, char[] pass)
        {
            PgpSecretKey pgpSecKey = pgpSec.GetSecretKey(keyId);

            if (pgpSecKey == null)
                return null;

            return pgpSecKey.ExtractPrivateKey(pass);
        }

        #endregion Private helpers
    }


}
