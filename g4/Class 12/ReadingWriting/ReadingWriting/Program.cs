using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DirectoryManipulation
            // Check what folder is your application
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            string appPath = @"C:\Users\DraganGelevski\source\repos\ReadingWriting\ReadingWriting";

            // Check if a folder exists
            bool papkaExists = Directory.Exists(appPath + @"\papka");
            bool papkaExistsString = Directory.Exists(@"C:\Users\DraganGelevski\source\repos\ReadingWriting\ReadingWriting\papka");
            bool papka2Exists = Directory.Exists(appPath + @"\papka2");
            Console.WriteLine($"Does papka exists: {papkaExists}");
            Console.WriteLine($"Does papka2 exists: {papka2Exists}");

            // Create a new folder
            string newPapka = appPath + @"\newPapka";
            Console.WriteLine($"Does newPapka exists before: {Directory.Exists(newPapka)}");
            if (!Directory.Exists(newPapka))
            {
                Directory.CreateDirectory(newPapka);
                Console.WriteLine("New directory was created!");
            }
            Console.WriteLine($"Does newPapka exists after: {Directory.Exists(newPapka)}");

            Console.WriteLine("Press anything to delete newPapka...");
            Console.ReadLine();

            // Delete a directory
            if (Directory.Exists(newPapka))
            {
                Directory.Delete(newPapka);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("newPapka was DELETED!");
                Console.ResetColor();
            }
            Console.ReadLine();
            #endregion
            #region FileManipulation - File
            // File exists
            string filesPath = @"C:\Users\DraganGelevski\source\repos\ReadingWriting\ReadingWriting\papka";
            bool testTxtExists = File.Exists(filesPath + @"\test.txt");
            bool test2TxtExists = File.Exists(filesPath + @"\test2.txt");
            Console.WriteLine($"Does test.txt exists: {testTxtExists}");
            Console.WriteLine($"Does test2.txt exists: {test2TxtExists}");

            // File Create
            if (!File.Exists(filesPath + @"\test.txt"))
            {
                File.Create(filesPath + @"\test.txt").Close();
                Console.WriteLine("A file was created!");
            }

            //Console.WriteLine("To delete this file press anything...");
            //Console.ReadLine();

            //// File Delete
            //if (File.Exists(filesPath + @"\test.txt"))
            //{
            //    File.Delete(filesPath + @"\test.txt");
            //    Console.WriteLine("A file was deleted!");
            //}
            //Console.ReadLine();

            // Writing in a file
            string testTxtPath = filesPath + @"\test.txt";
            if (File.Exists(testTxtPath))
            {
                File.WriteAllText(testTxtPath, "Hello SEDC! We are writing in a file");
                Console.WriteLine("Successfully written in a file!");
            }
            Console.ReadLine();

            // Read from a file
            if (File.Exists(testTxtPath))
            {
                string content = File.ReadAllText(testTxtPath);
                Console.WriteLine("This is the text:");
                Console.WriteLine(content);
            }
            Console.ReadLine();
            #endregion
            #region FileManipulation - Stream
            string streamTestPath = @"C:\Users\DraganGelevski\source\repos\ReadingWriting\ReadingWriting\papka\test.txt";

            // Writing with StreamWriter
            using (StreamWriter sw = new StreamWriter(streamTestPath))
            {
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine("We are writing text from StreamWriter!");
                Console.WriteLine("Writing is complete!");
            }

            // Writing without rewriting the document with StreamWriter
            using(StreamWriter sw = new StreamWriter(streamTestPath, true))
            {
                sw.WriteLine("Hello AGAIN!");
                sw.WriteLine("This is written on top of the previous one!");
                Console.WriteLine("Writing again!");
            }
            Console.ReadLine();

            using(StreamReader sr = new StreamReader(streamTestPath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string restContent = sr.ReadToEnd();
                Console.WriteLine($"First Line:{firstLine}");
                Console.WriteLine($"Second Line:{secondLine}");
                Console.WriteLine($"Rest of content:{restContent}");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
