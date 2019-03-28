using System;

namespace ZooApp
{
    
    public class Duck : Animal
    {
        public  string Motivation { get; set; }

        public void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}
