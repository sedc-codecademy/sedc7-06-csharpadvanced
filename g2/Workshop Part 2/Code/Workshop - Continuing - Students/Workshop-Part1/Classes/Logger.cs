using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Workshop_Part1.Classes {

    public enum LogType {

        Info = 1,
        Error = 2,
        Fatal = 3
    }

    //Simple logger 
    public static class Logger {

        //get the desktop path
        private static string logPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Log.txt";

        public static void Log(string msg, LogType type = LogType.Info) {
            string _text = DateTime.Now.ToString() + ":\t" + type + "\t" + msg + Environment.NewLine;
            File.AppendAllText(logPath, _text);
        }

        public static void DeleteLog() {
            if (File.Exists(logPath))
                File.Delete(logPath);
        }


    }
}
