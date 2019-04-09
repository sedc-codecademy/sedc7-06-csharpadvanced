using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = PersonGenerator.GetPersons();
            Console.WriteLine(persons.Count);

            var start = DateTime.Now;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("{ persons: [");
            for (int i = 0; i < persons.Count; i++)
            {
                var person = persons[i];
                sb.Append($"{{ {person.FirstName} {person.MiddleName} {person.LastName}}}\n");
            }
            sb.AppendLine("]}");
            string result = sb.ToString();

            //string result = "{ persons: [";
            //for (int i = 0; i < persons.Count; i++)
            //{
            //    var person = persons[i];
            //    result += $"{{ {person.FirstName} {person.MiddleName} {person.LastName}}}\n";
            //}
            //result += "]}";

            var end = DateTime.Now;

            Console.WriteLine(result.Length);
            var elapsed = (end - start).TotalMilliseconds;
            Console.WriteLine($"{elapsed}ms have elapsed");


        }
    }
}
