using System;
using System.Collections.Generic;

namespace Class2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle() { Height = 10, Width = 10, Color = "Red" });
            shapes.Add(new Triangle() { Height = 100, Width = 100, Color = "Green"});
            shapes.Add(new Rectrangle() { Height = 200, Width = 300, Color = "Blue"});

            var graphics = new Graphics();
            graphics.DrawShapes(shapes);

            Console.ReadLine();
        }
    }
}