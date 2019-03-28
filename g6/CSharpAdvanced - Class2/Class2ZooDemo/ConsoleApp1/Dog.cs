using System;
using ConsoleApp1.Interfaces;

namespace ZooApp
{
    public class Dog : Animal, IRun
    {
        public string Race { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark...");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }

    }
}
