using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            Subscriber1 s1 = new Subscriber1();
            Subscriber2 s2 = new Subscriber2();

            p.EventHandler += s1.Subscribe1Process;
            p.EventHandler += s2.Subscribe2Process;

            p.Publish("This is a message.");
            Console.ReadKey();
        }
    }
}
