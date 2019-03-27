using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClass
{
    class Empty:Object
    {
        public int MyProperty { get; set; }
    }

    class Empty2 : Object
    {
        public int MyProperty { get; set; }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Empty2 e2 = (Empty2)obj;
                return (MyProperty == e2.MyProperty) && (GetHashCode() == e2.GetHashCode());
            }
        }

        public override int GetHashCode()
        {
            return MyProperty;
        }

        public override string ToString()
        {
            return MyProperty.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //GetHashCode()
            //A hash code is a numeric value that is used to identify an object during equality testing.
            //It can also serve as an index for an object in a collection.
            //The GetHashCode method is suitable for use in hashing algorithms and data structures such as a hash table.

            //Equals(Object1)
            //Determines whether the specified object is equal to the current object.
            //https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netframework-4.7.2

            //GetType()
            //Gets the Type of the current instance.

            //ToString()
            //Returns a string that represents the current object.

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Empty Class");
            //Empty a = new Empty();
            //a.MyProperty = 1;
            //Empty b = new Empty();
            //b.MyProperty = 1;

            //Console.WriteLine($"a.GetHashCode: {a.GetHashCode()}, b.GetHashCode: {b.GetHashCode()}");
            //Console.WriteLine($"a == b: {a.Equals(b)}");
            //Console.WriteLine($"a.Type: {a.GetType()}, b.Type: {b.GetType()}");
            //Console.WriteLine($"a.ToString: {a.ToString()}");


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Empty2 Class");
            Empty2 a2 = new Empty2();
            a2.MyProperty = 2;
            Empty2 b2 = new Empty2();
            b2.MyProperty = 2;

            Console.WriteLine($"a2.GetHashCode: {a2.GetHashCode()}, b2.GetHashCode: {b2.GetHashCode()}");
            Console.WriteLine($"a2 == b: {a2.Equals(b2)}");
            Console.WriteLine($"a2.Type: {a2.GetType()}, b2.Type: {b2.GetType()}");
            Console.WriteLine($"a2.ToString: {a2.ToString()}");

            Console.ReadLine();
        }
    }
}
