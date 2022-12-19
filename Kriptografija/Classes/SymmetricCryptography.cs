﻿using System;
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

        public static void CreateKeyAndIvAES()
        {
            using (Aes myAes = Aes.Create())
            {
                string key = Convert.ToBase64String(myAes.Key);
                string IV = Convert.ToBase64String(myAes.IV);
                string writeToFile = key + "!seperate!" + IV;
                FileManager.WriteTextAES(writeToFile);
            }
        }
        public static byte[] EncryptStringToBytes_Aes(string textToEncrypt)
        {
            byte[] Key = Convert.FromBase64String(FileManager.GetKeyAES());
            byte[] IV = Convert.FromBase64String(FileManager.GetIVAES());

            if (textToEncrypt == null || textToEncrypt.Length <= 0)
                throw new ArgumentNullException("Problem u tekstu");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Problem s kljucem");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Problem s IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes symAesAlgorithm = Aes.Create())
            {
                symAesAlgorithm.Key = Key;
                symAesAlgorithm.IV = IV;
               
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = symAesAlgorithm.CreateEncryptor(symAesAlgorithm.Key, symAesAlgorithm.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(textToEncrypt);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        public static string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            byte[] Key = Convert.FromBase64String(FileManager.GetKeyAES());
            byte[] IV = Convert.FromBase64String(FileManager.GetIVAES());

            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}


