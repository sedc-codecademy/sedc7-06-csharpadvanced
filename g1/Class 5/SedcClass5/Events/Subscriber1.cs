using System;
using System.Threading;

namespace Events
{
    public class Subscriber1
    {
        public void Subscribe1Process(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber 1 received this message: {message}");
        }
    }
}
