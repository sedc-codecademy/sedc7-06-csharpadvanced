using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    #region Info
    /*
    - The Thread constructor takes a single argument: a delegate instance
    - The CLR provides the ThreadStart delegate class specifically for this purpose
        public delegate void ThreadStart( );
    - The method you attach to this delegate must take no parameters and must return void
    - You might create a new thread like this:
        Thread myThread = new Thread( new ThreadStart(myFunc) );
    */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Messages();
            MessagesInThreads();
        }
        public static void Messages()
        {
            Console.WriteLine("App start...");
            Thread.Sleep(2000); // Some work to be done
            Console.WriteLine("THREAD No. ONE ( 1 )");
            Thread.Sleep(2000); // Some work to be done
            Console.WriteLine("THREAD No. TWO ( 2 )");
            Thread.Sleep(2000); // Some work to be done
            Console.WriteLine("THREAD No. THREE ( 3 )");
            Console.WriteLine("App end...");
            Console.ReadLine();
        }
        public static void MessagesInThreads()
        {
            Console.WriteLine("App start...");
            new Thread(() => {
                Thread.Sleep(2000); // Some work to be done
                Console.WriteLine("THREAD No. ONE ( 1 )");
            }).Start();
            new Thread(() => {
                Thread.Sleep(2000); // Some work to be done
                Console.WriteLine("THREAD No. TWO ( 2 )");
            }).Start();
            new Thread(() => {
                Thread.Sleep(2000); // Some work to be done
                Console.WriteLine("THREAD No. THREE ( 3 )");
            }).Start();
            Console.WriteLine("App end...");

            Console.ReadLine();
        }
    }
}
