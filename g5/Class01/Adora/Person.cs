using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adora
{
    public class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        protected Person()
        {
            Console.WriteLine("No-param constructor called");
            Id = GetHashCode();
        }

        public Person(int age) : this()
        {
            Age = age;
        }

        public Person(string firstName, string lastName) : this()
        {
            Console.WriteLine("Two-param constructor called");
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            Console.WriteLine("Three-param constructor called");
            Age = age;
        }
    }
}
