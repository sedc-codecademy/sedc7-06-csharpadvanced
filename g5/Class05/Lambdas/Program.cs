using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sem = new StringEventManager();
            sem.Value = "Wekoslav";
            sem.Transform = input => input.ToUpper();
            sem.Execute += input => Console.WriteLine($"Value is {input}");
            sem.Run();
        }
    }
}
