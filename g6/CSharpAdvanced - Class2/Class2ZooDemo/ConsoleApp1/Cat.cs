using System;
using ConsoleApp1.Interfaces;

namespace ZooApp
{
    /// <summary>
    /// In C# we can inherit only from one class, in this case Animal, there is no such thing as multiple
    /// inheritance in C#. But we can IMPLEMENT multiple interfaces. Because syntax for inheriting and implementing 
    /// and interface is the same, a lot of people are confusing and interpreting inerfaces as a way to simulate
    /// multiple inheritance. That's WRONG!! Interfaces are NOT for multiple inheritance.
    /// </summary>
    public class Cat : Animal, IRun
    {
        public string Lazyness { get; set; }

        public void Run()
        {
            Console.WriteLine("Cat run...");
        }
    }
}
