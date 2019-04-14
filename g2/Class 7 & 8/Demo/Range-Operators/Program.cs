using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Action line = () => Console.WriteLine();

            #region Info
            /*
            - Range() method returns a collection of IEnumerable<T> type with specified number of elements
                and sequential values starting from the first element
            - Repeat() method generates a collection of IEnumerable<T> type with specified number of elements
                and each element contains same specified value
            */
            #endregion
            
            //Linq 65: find all odd two-digit numbers that divides 7
            //     Range, Repeat
            #region Linq 65
            //var numbers = Enumerable.Range(10, 90);
            //var dividing7 = numbers.Where(n => n % 7 == 0 && n % 2 != 0);
            //foreach (var item in dividing7)
            //{
            //    Console.Write(item + " ");
            //}
            //line();
            //IEnumerable<string> strings = Enumerable.Repeat("I like C#", 10);
            //foreach (var str in strings)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
