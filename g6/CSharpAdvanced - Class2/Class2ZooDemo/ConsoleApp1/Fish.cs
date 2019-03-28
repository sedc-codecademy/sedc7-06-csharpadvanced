using System;
using ConsoleApp1.Interfaces;

namespace ZooApp
{

    class Fish : Animal, ISwim
    {
        public bool Water { get; set; }

        public void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}
