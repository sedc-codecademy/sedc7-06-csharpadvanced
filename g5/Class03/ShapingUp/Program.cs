using ShapingUp.Shapes;
using ShapingUpLib;
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
            //Circle krug = new Circle(3);

            //double fside = 3;
            //double sside = 4;
            //double tside = 5;

            //if (Triangle.IsValidTriangle(fside, sside, tside))
            //{
            //    Triangle triangle = new Triangle(fside, sside, tside);
            //    Console.WriteLine(triangle.GetArea());
            //}
            //else
            //{
            //    Console.WriteLine("That is not valid");
            //}

            //double side = -2;
            //if (Square.IsValid(side))
            //{
            //    Square square = new Square(side);
            //    Console.WriteLine(square.GetArea());
            //}
            //else
            //{
            //    Console.WriteLine("That is not valid");
            //}


            ShapeCollection shapes = new ShapeCollection();
            shapes.AddShape(new Circle(10));
            shapes.AddShape(new Triangle(3, 4, 5));
            shapes.AddShape(new Triangle(3, 10, 12));
            shapes.AddShape(new Square(10));

            Console.WriteLine($"There are {shapes.Count()} shapes");
            Console.WriteLine($"Total area is {shapes.TotalArea()} ");
            Console.WriteLine($"Total perimeter is {shapes.TotalPerimeter()} ");

            Console.WriteLine($"Average area is {shapes.GetAverageArea()} ");
            Console.WriteLine($"Average area is {Helper.GetAverageArea(shapes)} ");

            Console.WriteLine(Helper.IsEven(2));
            Console.WriteLine(Helper.IsEven(3));

            Console.WriteLine(2.IsEven());
            Console.WriteLine(3.IsEven());

            var x = 10;
            Console.WriteLine(Helper.AddOne(Helper.Double(Helper.Square(x))));
            Console.WriteLine(x.Square().Double().AddOne());

            Triangle t = new Triangle(3, 7, 9);
            // these two are completely the same
            Console.WriteLine(IShapeHelper.GetRatio(t));
            Console.WriteLine(t.GetRatio());

            // these two are completely the same
            Console.WriteLine(IShapeHelper.GetMultipliedArea(t, 3));
            Console.WriteLine(t.GetMultipliedArea(3));

        }
    }
}
