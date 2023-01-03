using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Kriptografija.Classes
{
    public static class FileManager
    {
        private static string pathAES = "../../Datoteke/tajni_kljuc.txt";
        private static string pathRSAPublic = "../../Datoteke/javni_kljuc.txt";
        private static string pathRSAPrivate = "../../Datoteke/privatni_kljuc.txt";
        private static string pathSignedHash = "../../Datoteke/signed_hash.txt";
        private static string pathDefaultText = "../../Datoteke/default_text.txt";
        private static string pathRSAEncryptedText = "../../Datoteke/rsa_encrypted_text.txt";
        private static string pathAESEncryptedText = "../../Datoteke/aes_encrypted_text.txt";
        private static string pathHash = "../../Datoteke/hash.txt";
        private static string pathRSADecryptedText = "../../Datoteke/rsa_decrypted_text.txt";
        private static string pathAESDecryptedText = "../../Datoteke/aes_decrypted_text.txt";

        public static void WriteTextAES(string text)
        {
            File.WriteAllText(pathAES, text);
        }

        private static string ReadTextAES()
        {
            return File.ReadAllText(pathAES);
        }

        public static string GetKeyAES()
        {
            string entireAesText = ReadTextAES();
            string[] stringArray = entireAesText.Split(new string[] { "!seperate!" }, StringSplitOptions.None);
            return stringArray[0];
        }

        public static string GetIVAES()
        {
            string entireAesText = ReadTextAES();
            string[] stringArray = entireAesText.Split(new string[] { "!seperate!" }, StringSplitOptions.None); ;
            return stringArray[1];
        }

        public static string ReadFromFile(string fileName)
        {

            return File.ReadAllText(fileName);
        }

        public static void WritePublicKeyRSA(string text)
        {
            File.WriteAllText(pathRSAPublic, text);
        }

        public static string ReadPublicKeyRSA()
        {
            return File.ReadAllText(pathRSAPublic);
        }

        public static void WritePrivateKeyRSA(string text)
        {
            File.WriteAllText(pathRSAPrivate, text);
        }

        public static string ReadPrivateKeyRSA()
        {
            return File.ReadAllText(pathRSAPrivate);
        }

        public static void WriteSignedHash(string signedHash)
        {
            File.WriteAllText(pathSignedHash, signedHash);
        }
        public static string ReadSignedHash()
        {
            return File.ReadAllText(pathSignedHash);
        }

        public static void WriteDefaultText(string text)
        {
            File.WriteAllText(pathDefaultText, text);
        }
        public static string ReadDefaultText()
        {
            return File.ReadAllText(pathDefaultText);
        }
        public static void WriteRSAEncryptedText(string text)
        {
            File.WriteAllText(pathRSAEncryptedText, text);
        }
        public static void WriteRSADecryptedText(string text)
        {
            File.WriteAllText(pathRSADecryptedText, text);
        }
        public static void WriteAESEncryptedText(string text)
        {
            File.WriteAllText(pathAESEncryptedText, text);
        }
        public static void WriteAESDecryptedText(string text)
        {
            File.WriteAllText(pathAESDecryptedText, text);
        }
        public static void WriteHash(string text)
        {
            File.WriteAllText(pathHash, text);
        }
    }
}