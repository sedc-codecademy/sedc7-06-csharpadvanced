using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Start");
            // Task taht does not return anything
            Task taskOne = new Task(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Running a task after 1000 ms!");
            });
            taskOne.Start(); // starting a task manually 

            // Task that returns a value
            Task<bool> taskTwo = new Task<bool>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Running a task after 1000 ms and returning a value!");
                return true;
            });
            taskTwo.Start(); // starting a task manually 

            // Create and run task
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Running a task imidietly!");
            });
            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Running a task imidietly!");
            });
            // Running many tasks
            // They run in batches because they run in the first free thread they find
            // Depending on how many threads are available, that many tasks will execute at a time
            for (int i = 0; i <= 20; i++)
            {
                // By the time all tasks are started after the 1000 miliseconds, the loop is already done
                // That is why the value would be 20 for every iteration
                // If we put another variable here, we would introduce a new variable every time and keep the number of iteration
                int temp = i;
                Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Many tasks! This is no. {temp}");
                });
            }

            Console.WriteLine("App End");
            Console.ReadLine();
        }
    }
}
