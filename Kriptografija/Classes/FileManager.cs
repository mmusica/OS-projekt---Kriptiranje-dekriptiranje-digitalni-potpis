using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kriptografija.Classes
{
    public static class FileManager
    {
        private static string pathAES = "../../Datoteke/tajni_kljuc.txt";
        private static string pathRSAPublic = "../../Datoteke/javni_kljuc.txt";
        private static string pathRSAPrivate = "../../Datoteke/privatni_kljuc.txt";

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
    }
}