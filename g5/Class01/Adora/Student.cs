using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adora
{
    class Student : Person
    {
        public string Group { get; set; }

        private Student() : base()
        {

        }

        public Student(string group, string firstName, string lastName) : base(firstName, lastName)
        {
            Console.WriteLine("Descendant three-param constructor");
            Group = group;
        }
    }
}
