using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Task x = SendMessageAsync("Hey there!");

            Console.WriteLine($"Status: {x.Status}"); // The status of the task before it completed
            ShowAd("Cleanatron 5000");

            // This will not execute since a console.ReadLine() happened in ShowAd and it waits for the person to enter something in order to be done
            Console.WriteLine($"Status: {x.Status}"); // if we wait for the message and then hit any button it will execute after the task is completed and we can see a different status

            //A method that awaits an async method for a value ( we cant use await in here because we can't change the main method of the console app )
            //AwaitValuesFromSending("Hey there!");

            Console.ReadLine(); // Readline so we see the status ( the console app doesn't close )
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
            await Task.Run(() => {
                Thread.Sleep(5000); // Takes 5 seconds to check the message and send it ( pretending that its working 5 seconds )
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
