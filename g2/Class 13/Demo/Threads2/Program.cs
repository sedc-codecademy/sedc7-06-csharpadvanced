using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads2
{
    class IncrementerExample
    {
        int counter = 0;
        public void Incrementer()
        {
            //int counter = 0;
            while (counter < 50)
            {
                int temp;
                lock (this)
                {
                    temp = counter;
                    temp++;
                    //simulate some work in this method
                    Thread.Sleep(1);
                    counter = temp;
                }
                Console.WriteLine($"Thread {Thread.CurrentThread.Name} - Incrementer: {counter}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IncrementerExample ie = new IncrementerExample();

            Thread t1 = new Thread(new ThreadStart(ie.Incrementer));
            t1.IsBackground = true;
            t1.Name = "Thread ( 1 )";
            t1.Start();
            Console.WriteLine($"Started thread {t1.Name}");

            Thread t2 = new Thread(new ThreadStart(ie.Incrementer));
            t2.IsBackground = true;
            t2.Name = "Thread ( 2 )";
            t2.Start();
            Console.WriteLine($"Started thread {t2.Name}");

            Console.ReadLine();
        }
    }
}
