using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string path1 = Path.Combine(defaultPath, @"Files\TextWriterReader\Tekst1.txt");
            string path2 = Path.Combine(defaultPath, @"Files\TextWriterReader\Empty.txt");

            Console.WriteLine("\n--------------- Writing text ---------------");
            string test = @"Line 1 
                Line 2
                Line 3";
            File.WriteAllText(path1, test);

            Console.WriteLine("\n--------------- Reading text ---------------");
            string read = File.ReadAllText(path1);
            Console.WriteLine(read);
            Console.WriteLine();
            string read2 = File.ReadAllText(path1, Encoding.UTF8); //this is the default encoding
            Console.WriteLine(read2);

            Console.WriteLine("\n--------------- Creating an empty txt file ---------------");
            File.CreateText(path2);

            Console.ReadLine();
        }
    }
}
