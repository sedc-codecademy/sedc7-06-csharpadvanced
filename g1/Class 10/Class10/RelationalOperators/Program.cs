using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalOperators {
    class Program {
        static void Main(string[] args) {
            Box b1 = new Box(1, 2, 3);
            Box b2 = new Box(1, 2, 3);
            Box b3 = b2;

            Console.WriteLine(b1==b2);
            Console.WriteLine(b3==b1);
            Console.WriteLine(b2.Equals(b1));
            Console.WriteLine(b3.Equals(b2));
        }
    }
}
