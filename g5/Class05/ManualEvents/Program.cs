using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var sm = new StringManager
            {
                Value = "Wekoslav",
                Execute = WriteToConsole,
                NumberOfRuns = 7
            };
            sm.Execute = WriteToConsoleReversed;
            sm.Run();

            Console.WriteLine("---------------");

            var sem = new StringEventManager
            {
                Value = "Wekoslav",
                NumberOfRuns = 7
            };
            sem.Execute += WriteToConsole;
            sem.Execute += WriteToConsoleReversed;

            sem.Run();

        }

        static void WriteToConsole(string inputParameter)
        {
            Console.WriteLine($"Value passed to the method is {inputParameter}");
        }

        static void WriteToConsoleReversed(string inputParameter)
        {
            Console.WriteLine($"Value passed to the method is {new string(inputParameter.Reverse().ToArray())}");
        }
    }
}
