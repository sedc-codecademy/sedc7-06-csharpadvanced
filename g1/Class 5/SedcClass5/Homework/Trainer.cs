using System;
using System.Threading;

namespace Homework
{
    public delegate void AnnounceMarkDelegate(string name, int mark);
    public class Trainer
    {
        public event AnnounceMarkDelegate EventHandler;

        public void Announce(string name, int mark)
        {
            Console.WriteLine($"Trainer: Student: {name}, Mark: {mark}");

            EventHandler?.Invoke(name, mark);
            Thread.Sleep(5000);
        }
    }
}
