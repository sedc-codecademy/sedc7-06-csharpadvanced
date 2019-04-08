using System;
using System.Threading;

namespace Events
{
    class Subscriber2
    {
        public void Subscribe2Process(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Subscriber 2 received this message: {message}");
        }
    }
}
