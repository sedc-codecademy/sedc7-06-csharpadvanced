using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaccis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(41));
        }

        static long Fibonacci(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number == 1)
            {
                return 1;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
