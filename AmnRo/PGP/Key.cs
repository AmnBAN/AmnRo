using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System;
using System.IO;

namespace AmnRo.PGP
{
    public class Key
    {
        public static void GenerateKey(string keyname, string password, string keyStorePath,int keyLength)
        {
            IAsymmetricCipherKeyPairGenerator kpg = new RsaKeyPairGenerator();
            kpg.Init(new RsaKeyGenerationParameters(BigInteger.ValueOf(65537), new SecureRandom(), keyLength, 20));
            AsymmetricCipherKeyPair kp = kpg.GenerateKeyPair();
            FileStream PrivateOut = new FileInfo(string.Format("{0}\\{1}-PrivateKey.priv", keyStorePath, keyname)).OpenWrite();
            FileStream PublickOut = new FileInfo(string.Format("{0}\\{1}-PublicKey.pubk", keyStorePath, keyname)).OpenWrite();
            ExportKeyPair(PrivateOut, PublickOut, kp.Public, kp.Private, keyname, password.ToCharArray(), true);
            PrivateOut.Close();
            PublickOut.Close();
        }

        private static void ExportKeyPair(Stream secretOut, Stream publicOut, AsymmetricKeyParameter publicKey, AsymmetricKeyParameter privateKey, string identity, char[] passPhrase, bool armor)
        {
            if (armor)
            {
                secretOut = new ArmoredOutputStream(secretOut);
            }
            //TODO:change cas5 to AES
            PgpSecretKey secretKey = new PgpSecretKey(PgpSignature.DefaultCertification, PublicKeyAlgorithmTag.RsaGeneral, publicKey, privateKey, DateTime.Now, identity, SymmetricKeyAlgorithmTag.Cast5, passPhrase, null, null, new SecureRandom()
                //                ,"BC"
                );

            secretKey.Encode(secretOut);

            secretOut.Close();

            if (armor)
            {
                publicOut = new ArmoredOutputStream(publicOut);
            }

            PgpPublicKey key = secretKey.PublicKey;

            key.Encode(publicOut);

            publicOut.Close();
        }
    }
}
