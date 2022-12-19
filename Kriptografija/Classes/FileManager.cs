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
        private static string path = "../../Datoteke/";
        public static void WriteText(string text)
        {
            string filePath = path + "tajni_kljuc.txt";
            File.WriteAllText("filePath", text);
        }

    }
}
