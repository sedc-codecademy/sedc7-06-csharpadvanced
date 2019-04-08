using System;
using System.Threading;

namespace Events
{
    public delegate void MessageEventHandler(string message);
    public class Publisher
    {
        public event MessageEventHandler EventHandler;

        public void Publish(string message)
        {
            Console.WriteLine($"Publishing: {message}");
            Thread.Sleep(3000);

            NotifyAllSubscribers(message);
        }

        protected virtual void NotifyAllSubscribers(string message)
        {
            EventHandler?.Invoke(message);
        }
    }
}
