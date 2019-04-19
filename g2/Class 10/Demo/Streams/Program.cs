using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void ClearFiles(string pathOutputStream, string pathDestinationFile)
        {
            FileInfo fileTestCsBak = new FileInfo(pathOutputStream);
            if (!fileTestCsBak.Exists)
            {
                fileTestCsBak.Delete();
            }
            FileInfo fileTestTxtBak = new FileInfo(pathDestinationFile);
            if (!fileTestTxtBak.Exists)
            {
                fileTestTxtBak.Delete();
            }
        }

        #region Info
        /*
        - Reading and writing data is accomplished with the Stream class
        - Stream - Abstract class that supports reading and writing bytes
        - BinaryReader/BinaryWriter Read and write encoded strings and primitive datatypes to and from streams
        - FileStream For reading to and from File objects; supports random access to files; opens files
            synchronously by default; supports asynchronous file access
        - BufferedStream A stream that adds buffering to another stream
            BufferedStreams can improve the performance of the stream to which they are attached,
            but note that FileStream has buffering built in
        */
        #endregion
        static void Main(string[] args)
        {
            const int SizeBuff = 1024;

            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathInputStream = Path.Combine(defaultPath, @"Files\Streams\Source\Test1.cs");
            string pathOutputStream = Path.Combine(defaultPath, @"Files\Streams\Source\Test1.cs.bak");

            string pathSourceFile = Path.Combine(defaultPath, @"Files\Streams\Source\Test2.txt");
            string pathDestinationFile = Path.Combine(defaultPath, @"Files\Streams\Source\Test2.txt.bak");

            FileInfo fileTestCs = new FileInfo(pathInputStream);
            if (!fileTestCs.Exists)
            {
                return;
            }
            FileInfo fileTestTxt = new FileInfo(pathSourceFile);
            if (!fileTestTxt.Exists)
            {
                return;
            }

            #region BinaryReadWriteToFile
            //Console.WriteLine("\n--------------- Binary Read Write to File ---------------");

            //ClearFiles(pathOutputStream, pathDestinationFile);

            //Stream inputStream = File.OpenRead(pathInputStream);
            //Stream outputStream = File.OpenWrite(pathOutputStream);

            //// create a buffer to hold the bytes
            //byte[] buffer = new Byte[SizeBuff];

            //int bytesRead;

            //// while the read method returns bytes
            //// keep writing them to the output stream
            //while ((bytesRead = inputStream.Read(buffer, 0, SizeBuff)) > 0)
            //{
            //    outputStream.Write(buffer, 0, bytesRead);
            //}

            //inputStream.Close();
            //outputStream.Close();
            #endregion

            #region buffered I/O
            //Console.WriteLine("\n--------------- buffered I/O ---------------");

            //ClearFiles(pathOutputStream, pathDestinationFile);

            //Stream inputStream = File.OpenRead(pathInputStream);
            //Stream outputStream = File.OpenWrite(pathOutputStream);

            //// add buffered streams on top of the binary streams
            //BufferedStream bufferedInput = new BufferedStream(inputStream);
            //BufferedStream bufferedOutput = new BufferedStream(outputStream);

            //byte[] buffer = new Byte[SizeBuff];
            //int bytesRead;
            //while ((bytesRead = bufferedInput.Read(buffer, 0, SizeBuff)) > 0)
            //{
            //    bufferedOutput.Write(buffer, 0, bytesRead);
            //}
            //bufferedOutput.Flush();
            //bufferedInput.Close();
            //bufferedOutput.Close();
            #endregion

            #region ReadingWritingToTextFile
            Console.WriteLine("\n--------------- Reading Writing to Text File ---------------");

            ClearFiles(pathOutputStream, pathDestinationFile);

            FileInfo theSourceFile = new FileInfo(pathSourceFile);
            StreamReader reader = theSourceFile.OpenText();
            StreamWriter writer = new StreamWriter(pathDestinationFile, false);

            string text;
            //do
            //{
            //    text = reader.ReadLine();
            //    writer.WriteLine(text);
            //    Console.WriteLine(text);
            //} while (text != null);

            while ((text = reader.ReadLine()) != null)
            {
                writer.WriteLine(text);
                Console.WriteLine(text);
            }

            reader.Close();
            writer.Close();
            #endregion

            Console.ReadLine();
        }
    }
}
