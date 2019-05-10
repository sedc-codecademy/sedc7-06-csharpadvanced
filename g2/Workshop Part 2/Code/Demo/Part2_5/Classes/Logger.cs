using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_5.Classes
{
    //Enum log types
    public enum LogType
    {
        Info = 1,
        Error = 2,
        Fatal = 3
    }
    //Simple logger 
    public static class Logger
    {
        //get the desktop path
        private static string logPath = Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop) + @"\Log.txt";

        public static void Log(string msg, LogType type = LogType.Info)
        {
            string _text = DateTime.Now.ToString() + ":\t" + type + "\t"
                + msg + Environment.NewLine;
            File.AppendAllText(logPath, _text);
        }

        public static void DeleteLog()
        {
            if (File.Exists(logPath))
                File.Delete(logPath);
        }

        public static void ArchiveLog()
        {
            string _archiveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Archive";
            if (!Directory.Exists(_archiveFolder))
                Directory.CreateDirectory(_archiveFolder);

            if (File.Exists(logPath))
            {
                string _destination = _archiveFolder + @"\Log_"
                + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                File.Move(logPath, _destination);
            }
        }
    }
}
