using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Kriptografija.Classes
{
    public static class DigitalSignature
    {

        static SHA256 alg = Hash.GetSha256();
        static byte[] data;
        static byte[] hash;

        static byte[] signedHash;
        public static void InputDataToSignAndHash(string input)
        {
            data = Encoding.Unicode.GetBytes(input);
            hash = alg.ComputeHash(data);
        }
        public static void CreateSignature()
        {        
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(AsymmetricCryptography.GetPrivateKey());

                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm(nameof(SHA256));

                signedHash = rsaFormatter.CreateSignature(hash);
                ExportSignature(signedHash);

            }
        }
        private static void ExportSignature(byte[] signedHash)
        {
            FileManager.WriteSignedHash(Convert.ToBase64String(signedHash));
        }
        
        public static string ReturnSignedHashString()
        {
            return FileManager.ReadSignedHash();
        }

        public static string VerifySignature()
        {
            signedHash = Convert.FromBase64String(ReturnSignedHashString());
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(AsymmetricCryptography.GetPublicKey());
                RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm(nameof(SHA256));

                if (rsaDeformatter.VerifySignature(hash, signedHash))
                {
                    return "The signature is valid";
                }
                else
                {
                    return "The signature is not valid";
                }
            }
        }

    }
}
