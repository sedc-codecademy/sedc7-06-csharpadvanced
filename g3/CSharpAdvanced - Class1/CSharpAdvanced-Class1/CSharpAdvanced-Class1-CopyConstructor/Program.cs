using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public double GetSigma1() {
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

        public class Person : ICloneable
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
            public Person(Person other)
            {
                this.Name = other.Name;
                this.Age = other.Age;
            }
            
            #region ICloneable Members
            // Type safe Clone
            public Person Clone() { return new Person(this); }
            // ICloneable implementation
            object ICloneable.Clone()
            {
                return Clone();
            }
            #endregion

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
            Console.WriteLine(cords.GetSigma1());

            //Copy and Clone constructors
            Person xMan = new Person("xMan", 20);
            Person xManClone = xMan.Clone();
            Person xManCopy = new Person(xMan);
            xMan.PrintPerson();
            xManClone.PrintPerson();
            xManCopy.PrintPerson();

            xManClone.Name = xManClone.Name + " -> clonned";
            xManClone.PrintPerson();

            //something else :)
            int @int = 1; //using int as varaible
            Console.WriteLine(@int);

        }
    }
}
