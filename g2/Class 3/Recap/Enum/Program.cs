using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    enum DaysOfWeek
    {
        Monday = 0, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"------------- GetNames -------------");
            foreach (string d in Enum.GetNames(typeof(DaysOfWeek)))
            {
                Console.WriteLine(d);
            }

            Console.WriteLine($"------------- GetValues -------------");
            foreach (int d in Enum.GetValues(typeof(DaysOfWeek)))
            {
                System.Console.WriteLine(d);
            }

            Console.ReadLine();
        }
    }
}
