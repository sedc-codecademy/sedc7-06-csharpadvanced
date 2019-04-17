using System;
using System.Linq;

namespace Set_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            void line() => Console.WriteLine();

            //Linq 46:
            //Remove duplicate elements in a sequence of factors of 300.
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            //Find the unique Category IDs.

            //Using LINQ Union method Create one sequence that contains the unique values from both arrays
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            //Create one sequence that contains the unique first letter 
            //from both product and customer names.

            //Using LINQ Intersect method to create one sequence that contains the common first letter 
            //from both Product and Customer names.

            //Try to understand Intersect/Except in action
            //Intersect to create one sequence that contains the common values shared by both arrays.
            Console.WriteLine("----------------");
            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };
            var commonNumbers = A.Intersect(B);
            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
            line();
            Console.WriteLine("----------------");
            //Except to create a sequence that contains the values from numbers A that 
            //are not also in numbers B
            var exceptNumbers = A.Except(B);
            foreach (var n in exceptNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}