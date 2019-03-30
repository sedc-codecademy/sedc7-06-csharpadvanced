using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dog : Animal
    {
        // properties
        public string Race { get; set; }
        public string Color { get; set; }
        public bool IsPet { get; set; }
        public bool Vactinated { get; set; }

        public Dog()
        {
            Console.WriteLine("Hello. This is dog.");
        }

        public Dog(string name, int age, 
            string race, string color) 
            : base(name, age, Type.Seshtojad)
        {
            Race = race;
            Color = color;
        }
        // methods
        public void Bark()
        {
            Console.WriteLine("BARK BARK BARK");
        }

        // We write the same method with the same name
        // but we write override to change the implementation
        public override void Eat(string food)
        {
            base.Eat(food);
            Console.WriteLine($"The Dog {Name}:{Race} is eating {food}!");
        }
    }
}
