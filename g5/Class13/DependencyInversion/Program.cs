using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person weko = new Person();
            //weko.GetFullName();

            //Person usain = new Person
            //{
            //    FirstName = "Usain",
            //    LastName = "Bolt"
            //};
            //usain.GetFullName();

            var loader = new PersonLoader();
            var persons = loader.LoadPersons("persons.txt");
            foreach (var person in persons)
            {
                person.GetFullName();
            }
        }
    }
}
