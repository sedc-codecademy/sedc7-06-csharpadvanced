using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome {
    class Program {
        static void Main(string[] args) {

            string phrase;
            phrase = "Madam, I'm Adam";
            Console.WriteLine(phrase.IsPalindrom()); //True            
            phrase = "Madam, I am Adam";
            Console.WriteLine(phrase.IsPalindrom()); //False
            phrase = "Refer, refer!";
            Console.WriteLine(phrase.IsPalindrom()); //True

            double numeric;
            numeric = 123.321;
            Console.WriteLine(numeric.IsPalindrom()); //True

            int integer;
            integer = 11211;
            Console.WriteLine(integer.IsPalindrom()); //True      

            long bigInt;
            bigInt = 12345654321;
            Console.WriteLine(bigInt.IsPalindrom()); //True 

            Int16 i16 = 121;
            Console.WriteLine(i16.IsPalindrom());

        }
    }
}
