using ShapingUp.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle krug = new Circle(3);

            double fside = 3;
            double sside = 4;
            double tside = 5;

            if (Triangle.IsValidTriangle(fside, sside, tside))
            {
                Triangle triangle = new Triangle(fside, sside, tside);
                Console.WriteLine(triangle.GetArea());
            }
            else
            {
                Console.WriteLine("That is not valid");
            }

            double side = -2;
            if (Square.IsValid(side))
            {
                Square square = new Square(side);
                Console.WriteLine(square.GetArea());
            }
            else
            {
                Console.WriteLine("That is not valid");
            }

        }
    }
}
