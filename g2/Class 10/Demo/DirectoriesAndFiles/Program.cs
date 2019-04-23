using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesAndFiles
{
    class Program
    {
        #region Info
        /*
        - Directory class exposes static methods for creating, moving, and exploring directories
        - DirectoryInfo class is a similar class, but one that has nothing but instance members
            DirectoryInfo object have information about itself, including its name, full path, attributes,
            the time it was last accessed ...
        - File - same as Directory exposes static methods for working with files
        - FileInfo -same as DirectoryInfo exposes instance methods for working with instance
        */
        #endregion
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathDirectoriesAndFiles = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles");
            string pathDir1 = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles\Dir1");
            string pathDir2 = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles\Dir2");
            string pathNewFolder2 = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles\New Folder 2");

            #region Clear existing folders
            if (Directory.Exists(pathDir1))
            {
                Directory.Delete(pathDir1);
            }
            if (Directory.Exists(pathDir2))
            {
                Directory.Delete(pathDir2);
            }
            if (Directory.Exists(pathNewFolder2))
            {
                Directory.Delete(pathNewFolder2);
            }
            #endregion


            Console.WriteLine("\n--------------- DirectoryInfo and Directory---------------");

            #region DirectoryInfo for DirectoriesAndFiles
            DirectoryInfo dir = new DirectoryInfo(pathDirectoriesAndFiles);
            Console.WriteLine($"Dir Name: {dir.Name}");
            Console.WriteLine($"Dir FullName: {dir.FullName}");
            Console.WriteLine($"Dir CreationTime: {dir.CreationTime.ToString()}");
            #endregion

            Console.WriteLine();

            #region DirectoryInfo create Dir1
            DirectoryInfo dir1 = dir.CreateSubdirectory("Dir1");
            Console.WriteLine($"Dir1 Name: {dir1.Name}");
            Console.WriteLine($"Dir1 FullName: {dir1.FullName}");
            Console.WriteLine($"Dir1 CreationTime: {dir1.CreationTime.ToString()}");
            #endregion

            #region Directory create Dir2
            DirectoryInfo dir2 = Directory.CreateDirectory(pathDir2);
            Console.WriteLine($"Dir2 Name: {dir2.Name}");
            Console.WriteLine($"Dir2 FullName: {dir2.FullName}");
            Console.WriteLine($"Dir2 CreationTime: {dir2.CreationTime.ToString()}");
            #endregion

            Console.WriteLine();

            #region Move Dir2 to New Folder 2
            Directory.Move(pathDir2, pathNewFolder2);
            dir2 = new DirectoryInfo(pathNewFolder2);
            Console.WriteLine($"Dir2 New Name: {dir2.Name}");
            Console.WriteLine($"Dir2 New FullName: {dir2.FullName}");
            Console.WriteLine($"Dir2 New CreationTime: {dir2.CreationTime.ToString()}");
            #endregion

            Console.WriteLine();

            #region Delete Dir1
            //if (Directory.Exists(pathDir1))
            //{
            //    Directory.Delete(pathDir1);
            //}
            #endregion
            
            Console.WriteLine("\n--------------- FileInfo and File---------------");

            string pathAllFiles = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles\AllFiles");
            string pathAllFilesWork = Path.Combine(defaultPath, @"Files\DirectoriesAndFiles\AllFiles\Work");

            #region Copy all files from AllFiles to Work
            DirectoryInfo dirAllFiles = new DirectoryInfo(pathAllFiles);
            if (dirAllFiles.Exists)
            {
                FileInfo[] filesInAllFilesDir = dirAllFiles.GetFiles();
                Console.WriteLine($"Coping Files from  {dirAllFiles.Name}");
                foreach (var file in filesInAllFilesDir)
                {
                    Console.WriteLine($"Name: {file.Name}, CreationTime: {file.CreationTime}");
                    file.CopyTo(Path.Combine(pathAllFilesWork, file.Name), true);
                }
            }
            #endregion

            #region Delete *.txt from Work
            DirectoryInfo dirAllFilesWork = new DirectoryInfo(pathAllFilesWork);
            if (dirAllFilesWork.Exists)
            {
                FileInfo[] filesInAllFilesWorkDir = dirAllFilesWork.GetFiles("*.txt");
                Console.WriteLine($"Deleting .txt Files in {dirAllFilesWork.Name}");
                foreach (var file in filesInAllFilesWorkDir)
                {
                    Console.WriteLine($"Name: {file.Name}, CreationTime: {file.CreationTime}");
                    file.Delete();
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
