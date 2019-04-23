using System;
using System.IO;
using System.Text;

namespace TextWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = @"Line 1 
                Line 2
                Line 3";
            string path = @"C:\Users\Miodrag.Cekikj\Desktop\Tekst1.txt";
            File.WriteAllText(path, test);

            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            Console.WriteLine("------------");
            string read2 = File.ReadAllText(path, Encoding.UTF8); //this is the default encoding
            Console.WriteLine(read2);

            //create an empty .txt file
            path = @"C:\Users\Miodrag.Cekikj\Desktop\Empty.txt";
            File.CreateText(path);


            //TRY TO IMPLEMENT THE SAME SCENARIO BUT USING FileInfo/DirectoryInfo classes
        }
    }
}
