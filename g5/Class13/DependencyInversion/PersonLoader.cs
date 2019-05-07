using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class PersonLoader
    {
        public List<Person> LoadPersons(string filename = "person.txt")
        {
            var lines = File.ReadAllLines(filename);
            var result = new List<Person>();

            for (int i = 0; i < lines.Length; i+=2)
            {
                result.Add(new Person
                {
                    FirstName = lines[i],
                    LastName = lines[i + 1]
                });
            }

            return result;
        }
    }
}
