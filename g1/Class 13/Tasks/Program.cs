using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App start...");

            #region Example 1

            //Task myTask = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000ms");
            //});
            //myTask.Start();

            #endregion

            #region Example 2

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("We can now get the number...");
            //    return 6;
            //});
            //valueTask.Start();
            //Console.WriteLine(valueTask.Result);

            #endregion

            #region Example 3

            //Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("This is executed immediately...");
            //});

            #endregion

            #region Example 4

            for (int i = 1; i <= 20; i++)
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"TASK NO. {temp}");
                });
            }

            #endregion

            Console.WriteLine("App end...");
            Console.ReadLine();
        }
    }
}
