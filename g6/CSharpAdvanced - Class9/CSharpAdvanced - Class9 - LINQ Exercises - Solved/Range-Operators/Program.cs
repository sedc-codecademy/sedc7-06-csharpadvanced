using System;
using System.Collections.Generic;
using System.Linq;

namespace Range_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Find all odd two-digit numbers that divides 7
            //Take a look in Enumerable.Range functionality
            var numbers = Enumerable.Range(10, 90);

            var dividing7 = numbers.Where(n => n % 7 == 0 && n % 2 != 0);
            foreach (var item in dividing7)
            {
                Console.Write(item + " ");
            }
            Console.Write('\n');

            //Using Enumerable 'Repeat' print 'I like C#' 10 times
            IEnumerable<string> strings = Enumerable.Repeat("I like C#", 10);
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}