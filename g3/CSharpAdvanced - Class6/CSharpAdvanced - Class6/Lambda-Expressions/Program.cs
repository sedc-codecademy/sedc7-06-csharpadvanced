using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions {
    class Program {

        delegate int lambda(int input);
        delegate long multi(int x, int y, int z);
        delegate int noparamsLambda();

        static void Main(string[] args) {

            lambda addOne = x => x + 1;
            Console.WriteLine(addOne(1)); // Output: 2
            Console.WriteLine("--------------");

            multi multiply = (x, y, z) => x * y * z;
            Console.WriteLine(multiply(2,3,4)); //Output: 24
            Console.WriteLine("--------------");

            noparamsLambda randomNumber = () => {
                int random = new Random().Next();
                Console.WriteLine("Random number generated - {0}", random);
                return random;
            };
            Console.WriteLine(randomNumber());
            Console.WriteLine("--------------");

            int[] firstTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in firstTen)
                Console.Write("{0} ", num);
            Console.Write("\n");

            Console.WriteLine("Even numbers:");
            var even = firstTen.Where(n => n % 2 == 0);
            foreach (var num in even)
                Console.Write("{0} ", num);
            Console.Write("\n");

        }
    }
}
