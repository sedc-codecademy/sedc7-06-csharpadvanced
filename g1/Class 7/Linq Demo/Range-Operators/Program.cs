using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Operators {
    class Program {
        static void Main(string[] args) {
            
            //Linq 65: find all odd two-digit numbers that divides 7
            //Range
            var numbers = Enumerable.Range(10, 90).ToList();
            var dividing7 = numbers.Where(n => n % 7 == 0 && n % 2 != 0);
            foreach (var item in dividing7) {
                Console.Write(item + " ");
            }
            Console.Write('\n');

            //Repeat
            IEnumerable<string> strings = Enumerable.Repeat("I like C#", 10);
            foreach (var str in strings) {
                Console.WriteLine(str);
            }
            
        }
    }
}
