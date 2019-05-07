
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            //Console.Write("Enter Name: ");
            //FirstName = Console.ReadLine();
            //Console.Write("Enter Last Name: ");
            //LastName = Console.ReadLine();
        }

        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
