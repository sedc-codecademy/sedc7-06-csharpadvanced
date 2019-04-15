using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionAnonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func
            Func<int, int, string> Sum = (x, y) => $"The result is : {x + y}";
            Console.WriteLine(Sum(2,5));
            Func<string> HelloWorld = () => "Hello world";
            Func<int, string> IsEven = x => {
                Console.WriteLine("Processing...");
                if (x % 2 == 0) return "Even";
                return "Odd";
            };
            Console.WriteLine(IsEven(2));
            // Action
            Action<string> SayHello = x => Console.WriteLine($"Hello {x}");
            Action SayHelloWorld = () => Console.WriteLine("Hello world!");
            SayHello("Bob");
            SayHelloWorld();
            Console.ReadLine();
        }
    }
}
