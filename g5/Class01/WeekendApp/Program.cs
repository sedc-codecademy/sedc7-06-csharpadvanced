using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var isItWeekend = new IsItWeekend();

            Console.WriteLine(isItWeekend[DayOfWeek.Monday]);
            Console.WriteLine(isItWeekend[DayOfWeek.Saturday]);
        }
    }
}
