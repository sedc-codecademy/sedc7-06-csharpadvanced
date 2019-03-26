using System;

namespace CSharpAdvanced_Class1_CopyConstructor
{
    class Program
    {
        public class Coordinates
        {
            public int x;
            public int y;

            static readonly double sigma1;
            static readonly double sigma2;
            static readonly double sigma3;

            //1. Instance constructor
            public Coordinates()
            {
                x = 0;
                y = 0;
            }
            //2. Static constructor
            static Coordinates()
            {
                sigma1 = 0.6827;
                sigma2 = 0.9545;
                sigma3 = 0.9973;
            }

            public double GetSigma1()
            {
                return sigma1;
            }
            public double GetSigma2()
            {
                return sigma2;
            }
            public double GetSigma3()
            {
                return sigma3;
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            // Copy Constructor
            public Person(Person person)
            {
                this.Name = person.Name;
                this.Age = person.Age;
            }

            public void PrintPerson()
            {
                Console.WriteLine($"This is {this.Name}, Age is {this.Age}");
            }
        }
        static void Main(string[] args)
        {
            //Instance and static constructors
            Coordinates cords = new Coordinates();
            Console.WriteLine($"Default coordinates ({cords.x},{cords.y})");

            var date = new DateTime(2017, 5, 20);
            var dateNow = DateTime.Now;

            Console.WriteLine(cords.GetSigma1());

            //Copy constructor
            Person xMan = new Person("xMan", 20);
            Person xManCopy = new Person(xMan);
            xMan.PrintPerson();
            xManCopy.PrintPerson();

            //not to miss.
            int @int = 1;
            Console.WriteLine(@int);
        }
    }
}