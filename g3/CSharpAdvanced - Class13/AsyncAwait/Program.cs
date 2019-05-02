using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage("Hello there, we are SEDC students!");
            //Task x = SendMessageAsync("Hello there, we are SEDC students!");

            //Console.WriteLine($"{x.Status}");

            //ShowAd("Shampoo");

            Task y = MainThread();

            Console.ReadLine();

        }

        public static async Task MainThread()
        {
            await SendMessageAsync("Our message to be sent!");
            ShowAd("Potato");
        }

        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(5000);
            Console.WriteLine($"The message '{message}' is sent!");
        }

        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message '{message}' is sent!");
            });
        }

        public static void ShowAd(string commercialProduct)
        {
            Console.WriteLine("While you are waiting, let us show our ad:");
            Thread.Sleep(2000);
            Console.WriteLine("By the best product in the world");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(commercialProduct);
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.WriteLine(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            Console.WriteLine("FREE");
            Console.ResetColor();
            Console.WriteLine("shipping!");
            Console.ReadLine();
        }
    }
}
