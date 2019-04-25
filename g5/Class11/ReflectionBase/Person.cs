using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBase
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        [Sedc(StringName = "Име")]
        public string FirstName { get; set; }

        [Sedc(StringName = "Презиме")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Sedc(Ignore = true)]
        public string Secret { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return $"{FullName} ({Age})";
        }

    }
}
