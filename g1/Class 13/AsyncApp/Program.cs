using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendMessage("Hey there SEDC students!");
            var x = SendMessageAsync("Hey there SEDC students!");
            Console.WriteLine(x.Status);

            ShowAd("Potato");
            Console.ReadLine();
            Console.WriteLine(x.Status);
            Console.ReadLine();

            // Making sync with async ?! (complicating code for nothing )
            //MainThread();
            //Console.ReadLine();
        }

        // Making sync with async ?! ( complicating code for nothing )
        public static async Task MainThread()
        {
            await SendMessageAsync("Hey there SEDC students!");
            ShowAd("Potato");
            Console.ReadLine();
        }


        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...(Sync)");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {message} was sent (Sync)!");
        }

        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...(Async)");
            Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message {message} was sent (Async)!");
            });
        }

        public static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Console.Write("Buy the best product in the world ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);
            Console.ResetColor();
            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.WriteLine(" shipping worldwide!");
            Console.ReadLine();
        }
    }
}
