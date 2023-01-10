using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Kriptografija.Classes
{
    public static class SymmetricCryptography
    {
        public static byte[] Key;
        public static byte[] IV;
        public static void CreateKeyAndIvAES()
        {
            using (Aes myAes = Aes.Create())
            {
                string key = Convert.ToBase64String(myAes.Key);
                string iv = Convert.ToBase64String(myAes.IV);
                string writeToFile = key + "!seperate!" + iv;
                FileManager.WriteTextAES(writeToFile);
                Key = Convert.FromBase64String(FileManager.GetKeyAES());
                IV = Convert.FromBase64String(FileManager.GetIVAES());
            }
        }
        public static byte[] EncryptStringToBytes_Aes(string textToEncrypt)
        {
            if (textToEncrypt == null || textToEncrypt.Length <= 0)
                throw new ArgumentNullException("Problem u tekstu");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Problem s kljucem");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Problem s IV");
            byte[] encrypted;
         
            using (Aes symAesAlgorithm = Aes.Create())
            {
                symAesAlgorithm.Key = Key;
                symAesAlgorithm.IV = IV;
                ICryptoTransform encryptor = symAesAlgorithm.CreateEncryptor(symAesAlgorithm.Key, symAesAlgorithm.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                           
                            swEncrypt.Write(textToEncrypt);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }    
            return encrypted;
        }
        public static string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}


