using System;

namespace BasicOperators {
    class Program {
        static void Main(string[] args) {
            Box b1 = new Box(1, 2, 3);
            b1.PrintBox();
            Box b2 = new Box(2, 3, 4);
            b2.PrintBox();
            Box b3 = b1 + b2;
            b3.PrintBox();
            Console.WriteLine(b3.Volume());
            
            b3--;
            b3.PrintBox();
            Console.WriteLine(b3.Volume());

            var b4 = -b2;
            b4.PrintBox();
            Console.WriteLine(b4.Volume());

            Box b5 = new Box(0, 0, 0);
            Console.WriteLine(!b5);
            Box b6 = new Box(1, 1, 1);
            Console.WriteLine(!b6);

            Box b7 = b6 + 1;
            b7.PrintBox();
            Console.WriteLine(b7.Volume());


            //Products example
            Product p1 = new Product("Mleko", 20, 50);
            Product p2 = new Product("Leb", 30, 20);
            Product p11 = new Product("Voda", 50, 10);

            var p3 = p1 + p2;
            var p4 = p1 - p2;
            var p5 = p1 * p2;
            var p6 = p1 / p2;
            var p7 = p1 % p2;
            p1++;
            p2--;

            var p10 = p11 + 40;

            bool t = p1 > p2;
            bool t1 = p1 == p2;

            if (p1 == p2)
            {
                var p12 = p1 + p2.Quantity;
            }
        }
    }
}
