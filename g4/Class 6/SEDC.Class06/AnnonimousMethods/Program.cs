using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonimousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Bob", "Jill", "Wayne", "Greg", "Dragimiletisha"
            };
            // standard way of using annonimous functions with higher order methods
            var found = names.Find(x => x == "Bob");
            Console.WriteLine(found);
            Console.ReadLine();

            // Func and Action annonimous functions
            // Func has always return value
            // int1 = parameter, int2 parameter, int3 return
            Func<int, int, int> sum = (x, y) => x + y;
            // int1 = parameter, int2 parameter, bool return
            Func<int, int, bool> checkLarger = (x, y) =>
            {
                if (x > y) return true;
                return false;
            };
            // Action is always void
            Action<string> hello = x => Console.WriteLine($"Hey {x}");

            Console.WriteLine($"sum: {sum(2,3)}" );
            Console.WriteLine($"checkLarger: {checkLarger(9,3)}");
            Console.WriteLine($"hello:");
            hello("Bob");
            Console.ReadLine();
        }
    }
}
