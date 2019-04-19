using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWriterReader {
    class Program {
        static void Main(string[] args) {
            
            string test = @"Line 1 
                Line 2
                Line 3";
            string path = @"C:\Users\igor.micev\Desktop\Tekst1.txt";
            File.WriteAllText(path, test);

            path = @"C:\Users\igor.micev\Desktop\Tekst2.txt";
            string[] lines = ("This is some words to write in lines into a text file").Split(' ');
            File.WriteAllLines(path, lines);

            string read = File.ReadAllText(path);
            Console.WriteLine(read);
            Console.WriteLine("------------");
            string read2 = File.ReadAllText(path, Encoding.UTF8); //this is the default encoding
            Console.WriteLine(read2);

            //create an empty .txt file
            path = @"C:\Users\igor.micev\Desktop\Empty.txt";
            File.CreateText(path); 

        }
    }
}
