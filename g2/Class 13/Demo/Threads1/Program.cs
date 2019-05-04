using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(WriteY));
            t1.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.Write("x");
            }
            t1.Join();
            Console.WriteLine("(App) printing finished");

            Console.ReadLine();
        }

        static void WriteY()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.Write("y");
            }
            Console.WriteLine("(Thread) printing finished");
        }
    }
}
