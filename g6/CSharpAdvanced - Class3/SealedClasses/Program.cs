using SealedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Rectangle() { Height = 200, Width = 300, Color = "Blue" });

            var graphics = new Graphics();
            graphics.DrawShapes(shapes);

            Console.ReadLine();
        }
    }
}
