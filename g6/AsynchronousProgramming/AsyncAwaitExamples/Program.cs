using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Task x = SendMessageAsync("Hey there!");

            Console.WriteLine($"Status: {x.Status}");
            ShowAd("Cleanatron 5000");

            Console.WriteLine($"Status: {x.Status}");

            //AwaitValuesFromSending("Hey there!");

            Console.ReadLine();
        }
        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(5000); // Takes 5 seconds to check the message and send it ( pretending that its working 5 seconds )
            Console.WriteLine($"The message {message} is sent!");
        }
        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine($"The message {message} is sent!");
            });
        }
        public static async Task<string> SendMessageWithReturnAsync(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(5000); // Takes 5 seconds to check the message and send it ( pretending that its working 5 seconds )
            return $"The message {message} is sent!";
        }
        public static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Console.Write("Buy the best product in the world: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(product);
            Console.ResetColor();
            Console.Write(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("FREE");
            Console.ResetColor();
            Console.WriteLine(" shipping!");
            Console.ReadLine();
        }
        public static async void AwaitValuesFromSending(string message)
        {
            // awaiting a value from a method
            var y = await SendMessageWithReturnAsync(message);
            Console.WriteLine(y);
        }
    }
}
