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
            /*
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

            var endsWithE = strings.First(x => x.EndsWith("ee"));
            Console.WriteLine("The first string ends with 'ee' is: {0}", endsWithE);
            var endsWithE2 = strings.First(x => x[x.Length-1] == 'e');
            Console.WriteLine("The first string ends with 'e' is: {0}", endsWithE2);

            */
            // Use First to find the first element in the array that ends with 'e'.


            //Find all odd numbers that divide 5 in the range [100,999]
            var threeDigitNumbers = Enumerable.Range(1000, 9000);
            var oddDividing5 = threeDigitNumbers.Where(n => (DividesDigitsSum(n) && DividesDigitsProduct(n)));
            foreach (var num in oddDividing5) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static bool DividesDigitsSum(int n) {
            int s = 0;
            int temp = n;
            while (temp > 0) {
                s += (temp % 10);
                temp = temp / 10;
            } 
                return n % s == 0; 
        }

        public static bool DividesDigitsProduct(int n) {
            int p = 1;
            int temp = n;
            while (temp > 0) {
                p *= (temp % 10);
                temp = temp / 10;
            }
            if (p != 0)
                return n % p == 0;
            else
                return false;
        }

    }
}
