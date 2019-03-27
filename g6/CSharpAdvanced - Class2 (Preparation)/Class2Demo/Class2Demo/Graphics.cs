using System;
using System.Collections.Generic;

namespace Class2Demo
{
    public class Graphics
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle.");
                        break;
                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle.");
                        break;
                }
            }
        }
    }
}