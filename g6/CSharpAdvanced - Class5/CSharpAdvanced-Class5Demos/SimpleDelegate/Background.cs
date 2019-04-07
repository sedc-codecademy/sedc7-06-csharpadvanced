using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class Background
    {
        /// <summary>
        /// Here we are just declaring a compatible static method
        /// with same signature as our delegate, void as a return type and 
        /// string as an input parameter..
        /// </summary>
        /// <param name="note"></param>
        public static void Note(string note)
        {
            Console.WriteLine("({0})", note);
        }
    }
}
