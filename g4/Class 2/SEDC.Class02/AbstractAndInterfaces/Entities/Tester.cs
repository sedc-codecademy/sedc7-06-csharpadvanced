using AbstractAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces.Entities
{
    public class Tester : Employee, ITester, IHuman
    {
        public int BugsFound { get; set; }
        public Tester()
        {
            Position = Job.Tester;
        }
        public void Talk()
        {
            Console.WriteLine("Bla bla bla");
        }
        public override void PrintEmployee()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Bugs Found So Far: {BugsFound}");
        }
        public void FindBug()
        {
            Console.WriteLine("I found bug!");
            BugsFound++;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("You angered the developers!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
