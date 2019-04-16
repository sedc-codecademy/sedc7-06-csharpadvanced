using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperators {
    class Program {
        static void Main(string[] args) {
            Box b1 = new Box(1, 2, 3);
            b1.PrintBox();
            Box b2 = new Box(2, 3, 4);
            b2.PrintBox();
            Box b3;
            b3 = b1 + b2;
            b3.PrintBox();
            Console.WriteLine(b3.Volume());

            b3--;
            b3.PrintBox();
            Console.WriteLine(b3.Volume());

            Box b4;
            b4 = -b2;
            b4.PrintBox();
            Console.WriteLine(b4.Volume());

            Box b5 = new Box(0, 0, 0);
            Console.WriteLine(!b5);
            Box b6 = new Box(1, 1, 1);
            Console.WriteLine(!b6);

        }
    }
}
