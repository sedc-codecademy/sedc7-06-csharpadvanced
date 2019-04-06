using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sem = new StringEventManager { Value = "Wekoslav" };
            sem.Execute += WriteToConsole;

            sem.Run();
        }

        static void WriteToConsole(string inputParameter)
        {
            Console.WriteLine($"Value passed to the method is {inputParameter}");
        }

    }
}
