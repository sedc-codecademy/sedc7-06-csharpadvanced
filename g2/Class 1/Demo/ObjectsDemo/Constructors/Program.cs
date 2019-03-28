using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Coordinates
    {
        private int x;
        private int y = 0;

        private static readonly int c;

        //1. Instance constructor
        public Coordinates()
        {
            Console.WriteLine("Instance constructor");
            this.x = 0;
            this.y = 0;
        }

        //2. Static constructor
        static Coordinates()
        {
            Console.WriteLine("Static Constructor");
            c++;
        }

        public int GetC()
        {
            return c;
        }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        //3. Copy constructor
        public Person(Person other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
        }

        //Type safe Clone
        //public Person Clone()
        //{
        //    Console.WriteLine("Person Clone");
        //    return new Person(this);
        //}
        //ICloneable implementation
        //object ICloneable.Clone()
        //{
        //    Console.WriteLine("ICloneabale Clone");
        //    return Clone();
        //}

        public object Clone()
        {
            return new Person(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Constructors Instance, Static - Coordinates
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("Coordinates");
            //Coordinates c1 = new Coordinates();
            //Console.WriteLine($"c: {c1.GetC()}");
            //Coordinates c2 = new Coordinates();
            //Console.WriteLine($"c: {c2.GetC()}");
            #endregion

            #region Constructors - Person
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Person - p2 and p1 are the references to the same object");
            //Person p1 = new Person("P1", 1);
            //Person p2 = p1;
            //Console.WriteLine($"p1: {p1.Name}, p2: {p2.Name}");
            //Console.WriteLine($"p1 == p2: {p1 == p2}");
            //Console.WriteLine($"p2 referenced p1: {object.ReferenceEquals(p1, p2)}");
            //Console.WriteLine("p1 and p2 are the references to the same object");
            //p2.Name = "P2";
            //p2.Age = 2;
            //Console.WriteLine($"p1: {p1.Name}, p2: {p2.Name}");

            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Person - p2 Copy p1");
            //Person p3 = new Person("P3", 3);
            //Person p4 = new Person(p3);
            //Console.WriteLine($"p3: {p3.Name}, p4: {p4.Name}");
            //Console.WriteLine($"p3 == p4: {p3 == p4}");
            //Console.WriteLine($"p4 referenced p3: {object.ReferenceEquals(p3, p4)}");
            //Console.WriteLine("p3 and p4 are separate objects");
            //p4.Name = "P4";
            //p4.Age = 4;
            //Console.WriteLine($"p3: {p3.Name}, p4: {p4.Name}");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Person - p6 Clone p5");
            Person p5 = new Person("P5", 5);
            Person p6 = (Person)p5.Clone();
            Console.WriteLine($"p5: {p5.Name}, p6: {p6.Name}");
            Console.WriteLine($"p5 == p6: {p5 == p6}");
            Console.WriteLine($"p6 referenced p5: {object.ReferenceEquals(p5, p6)}");
            Console.WriteLine("p5 and p6 are separate objects");
            p6.Name = "P6";
            p6.Age = 6;
            Console.WriteLine($"p5: {p5.Name}, p6: {p6.Name}");


            #endregion

            Console.ReadLine();
        }
    }
}
