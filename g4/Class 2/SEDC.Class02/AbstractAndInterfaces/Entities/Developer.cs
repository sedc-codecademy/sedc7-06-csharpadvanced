using AbstractAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces.Entities
{
    public class Developer : Employee, IDeveloper
    {
        public List<string> ProgrammingLanugages { get; set; }
        public Developer()
        {
            Position = Job.Developer;
            ProgrammingLanugages = new List<string>();
        }
        public string Code()
        {
            Console.WriteLine("Click, clack, shtrak...");
            return "Awesome Code";
        }
        public override void PrintEmployee()
        {
            Console.WriteLine($"{FirstName} {LastName}, Languages:");
            foreach (string lang in ProgrammingLanugages)
            {
                Console.WriteLine(lang);
            }
            if (ProgrammingLanugages.Count == 0) Console.WriteLine("None");
        }
    }
}
