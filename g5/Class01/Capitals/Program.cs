using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitals = new Dictionary<string, string>
            {
                { "Bulgaria", "Sofia" },
                { "Greece", "Athens" },
                { "Serbia", "Belgrade" },
                { "Albania", "Tirana" },
                { "Kosovo", "Prishtina" },
                { "Madagaskar", "Antanarive" },
                { "Chile", "Santiago" },
                { "Mongolia", "Ulan Bator" }
            };

            while (true)
            {
                Console.Clear();
                Console.Write("Enter a country: ");
                var country = Console.ReadLine();
                if (capitals.ContainsKey(country))
                {
                    Console.WriteLine($"The capital of {country} is {capitals[country]}");
                }
                else
                {
                    Console.WriteLine($"The country of {country} is not in the database");
                }
                Console.ReadLine();
            }
        }
    }
}
