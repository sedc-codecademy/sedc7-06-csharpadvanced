using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(6);
            s.Squish();

            Console.WriteLine(s.Width);
            Console.WriteLine(s.Height);

        }

        public static int GetPerimeter(Rectangle rectangle)
        {
            return (rectangle.Width + rectangle.Height) * 2;
        }
    }
}
