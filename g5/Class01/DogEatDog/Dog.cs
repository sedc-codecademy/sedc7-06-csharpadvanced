using System;

namespace DogEatDog
{
    internal class Dog
    {
        public string Name { get; set; }
        public Race Race { get; set; }
        public int Age { get; set; }

        public Dog(string name, Race race, int age)
        {
            Name = name;
            Race = race;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} the {Race} is {Age} years old";
        }

        public string Bark()
        {
            return "Woof-woof";
        }
    }
}