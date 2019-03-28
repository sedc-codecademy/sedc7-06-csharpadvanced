using System;
using System.Collections.Generic;

namespace Class2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Shape() { Height = 10, Width = 10, Color = "Red", Type = ShapeType.Circle });
            shapes.Add(new Shape() { Height = 100, Width = 100, Color = "Green", Type = ShapeType.Triangle });
            shapes.Add(new Shape() { Height = 200, Width = 300, Color = "Blue", Type = ShapeType.Circle });

            var graphics = new Graphics();
            graphics.DrawShapes(shapes);

            Console.ReadLine();
        }
    }
}