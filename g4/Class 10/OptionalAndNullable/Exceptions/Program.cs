using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidCountryNameException : Exception
    {
        public string CountryName { get; set; }
        public InvalidCountryNameException(string countryName)
        {
            CountryName = countryName;
        }
        public void PrintError()
        {
            Console.WriteLine($"The name {CountryName} is too short!");
            Console.WriteLine("Extra information:");
            Console.WriteLine($"Source: {base.Source}");
            Console.WriteLine($"Target: {base.TargetSite}");
            Console.WriteLine($"Trace: {base.StackTrace}");
        }
        public void ReportError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error reported!");
            Console.ResetColor();
            // Odi vo baza i pisuva error
            // Praka mail do QA
            // Praka mail do Developers
        }
    }
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public Human(string first, string last, string country)
        {
            FirstName = first;
            LastName = last;
            if(country.Length < 3)
            {
                throw new InvalidCountryNameException(country);
            }
            Country = country;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Human bob = new Human("Bob", "Bobski", "ii");
            }
            catch (InvalidCountryNameException ex)
            {
                ex.PrintError();
                ex.ReportError();
            }
            Console.ReadLine();
        }
    }
}
