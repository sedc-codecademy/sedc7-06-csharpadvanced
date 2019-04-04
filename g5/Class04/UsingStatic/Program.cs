using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;
using static UsingStatic.MethodBag;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 12345.678;
            var root = Sqrt(number);

            var num2 = Double(number);

            var c = new ComplexNumber { Real = 0, Imaginary = 1 };
            Console.WriteLine(c);
        }
    }
}
