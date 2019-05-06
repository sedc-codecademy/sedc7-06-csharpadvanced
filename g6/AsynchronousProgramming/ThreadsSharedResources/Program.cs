using System;
using System.Threading;

namespace ThreadsSharedResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(DisplayThread1));
            Thread thread2 = new Thread(new ThreadStart(DisplayThread2));

            thread1.Start();
            thread2.Start();

            Console.ReadLine();
        }

        static string _threadOutput = "";

        static void DisplayThread1()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Display Thread 1");

                // Assign the shared memory to a message about thread #1  
                _threadOutput = "Hello Thread1";


                Thread.Sleep(1000);  // simulate a lot of processing   

                // tell the user what thread we are in thread #1, and display shared memory  
                Console.WriteLine("Thread 1 Output --> {0}", _threadOutput);

            }
        }

        static void DisplayThread2()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Display Thread 2");


                // Assign the shared memory to a message about thread #2  
                _threadOutput = "Hello Thread2";


                Thread.Sleep(1000);  // simulate a lot of processing  

                // tell the user we are in thread #2  
                Console.WriteLine("Thread 2 Output --> {0}", _threadOutput);

            }
        }
    }
}
