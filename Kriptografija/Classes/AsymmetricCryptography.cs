using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografija.Classes
{
    public static class AsymmetricCryptography
    {
        public static void CreateKeyPair()
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048);
            var privateKey = cryptoServiceProvider.ExportParameters(true);
            var publicKey = cryptoServiceProvider.ExportParameters(false);
            FileManager.WritePrivateKeyRSA(ConvertKeyToString(privateKey));
            FileManager.WritePublicKeyRSA(ConvertKeyToString(publicKey));
        }

        private static RSAParameters GetPublicKey()
        {
            string publicKeyString = FileManager.ReadPublicKeyRSA();
            return ConvertKeyStringToRSAParameters(publicKeyString);
        }

        private static RSAParameters GetPrivateKey()
        {
            string privateKeyString = FileManager.ReadPrivateKeyRSA();
            return ConvertKeyStringToRSAParameters(privateKeyString);
        }

        private static string ConvertKeyToString(RSAParameters key)
        {
            var stringWriter = new StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, key);
            return stringWriter.ToString();
        }

        private static RSAParameters ConvertKeyStringToRSAParameters(string keyString)
        {
            var sr = new StringReader(keyString);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }

        public static string RSAEncrypt(string plainTextData)
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider();
            cryptoServiceProvider.ImportParameters(GetPublicKey());
            var bytesPlainTextData = Encoding.Unicode.GetBytes(plainTextData);
            //apply pkcs#1.5 padding and encrypt our data 
            try
            {
                var bytesCypherText = cryptoServiceProvider.Encrypt(bytesPlainTextData, false);
                var cypherText = Convert.ToBase64String(bytesCypherText);
                return cypherText;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Cant encode twice");

            }
            return "";
        }

        public static string RSADecrypt(string cypherText)
        {
            try
            {
                var bytesCypherText = Convert.FromBase64String(cypherText);
                var cryptoServiceProvider = new RSACryptoServiceProvider();
                cryptoServiceProvider.ImportParameters(GetPrivateKey());
                try
                {
                    var bytesPlainTextData = cryptoServiceProvider.Decrypt(bytesCypherText, false);
                    return Encoding.Unicode.GetString(bytesPlainTextData);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Decrypt fully first");

                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Text cannot be further decrypted");
            }
            return "";
        }
    }
}

