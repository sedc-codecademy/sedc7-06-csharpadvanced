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
            //Console.WriteLine("App start...");
            //Task myTask = new Task(()=> {
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000ms");
            //});

            //myTask.Start();

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("We can now get the number...");
            //    return 6;
            //});
            //valueTask.Start();
            //Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("This is executed immedietly...");
            //});
            ////Console.WriteLine(valueTask.Result);
            //Console.WriteLine("App End...");

            for (int i = 1; i <= 20; i++)
            {
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"TASK NO. {temp}");
                });
            }
            Console.ReadLine();
        }
    }
}
