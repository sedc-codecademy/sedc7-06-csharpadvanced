using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labmda_Exercising {
    class Program {
        
        static void Main(string[] args) {
            
            //This sample demonstrates an indexed Where clause that returns digits whose 
            // name is shorter than their value
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits) {
                Console.WriteLine("The length of the word '{0}' is shorter than its value.", d);
            }

            //This sample uses First to find the first element in the array that starts with 't'.
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string startsWithT = strings.First(s => s[0] == 't');
            Console.WriteLine("The first string starting with 't' is: {0}", startsWithT);

            //Find all odd numbers that divide 5 in the range [100,999]
            var threeDigitNumbers = Enumerable.Range(100, 900); 
            var oddDividing5 = threeDigitNumbers.Where(n => n % 5==0 && n%2 != 0);
            foreach (var num in oddDividing5) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
