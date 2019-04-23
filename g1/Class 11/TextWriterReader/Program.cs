using System;
using System.Text;
using System.IO;

namespace TextWriterReader {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Temp\Tekst1.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }


            string test = @"Line 1 
                Line 2
                Line 3";

            File.WriteAllText(path, test);

            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            Console.WriteLine("------------");
            string read2 = File.ReadAllText(path, Encoding.UTF8); //this is the default encoding
            Console.WriteLine(read2);

            //create an empty .txt file
            path = @"C:\Temp\Empty.txt";
            File.CreateText(path); 

        }
    }
}
