using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cities = new Dictionary<string, string>();

            cities.Add("MACEDONIA", "Skopje");
            cities.Add("SERBIA", "Belgrad");
            cities.Add("BULGARIA", "Sofia");
            cities.Add("GREECE", "Athens");
            cities.Add("ALBANIA", "Tirana");
            cities.Add("KOSOVO", "Pristina");

            string country = "";
            Console.Write("Enter the country name: ");
            country = Console.ReadLine().ToUpper();

            if (cities.ContainsKey(country))
            {
                Console.WriteLine($"The capital of {country} is {cities[country]}");
            }
            else
            {
                Console.WriteLine("This country does not exists in our structure");
            }
            Console.ReadLine();
        }
    }
}
