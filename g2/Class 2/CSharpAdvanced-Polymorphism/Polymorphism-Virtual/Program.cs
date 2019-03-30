using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Virtual
{
    class Program
    {
        class Caller
        {
            public void CallerArea(Shape sh)
            {
                Console.WriteLine("Area {0}", sh.Area());
            }
        }
        static void Main(string[] args)
        {
            Shape s = new Shape(10, 10);
            Shape s2 = new Shape();
            Rectangle r = new Rectangle(10, 7);
            Rectangle r2 = new Rectangle();
            Triangle t = new Triangle(10, 5);
            Triangle t2 = new Triangle();
            Caller c = new Caller();

            c.CallerArea(s);
            c.CallerArea(r);
            c.CallerArea(r2);
            c.CallerArea(t);
            c.CallerArea(t2);
        }
    }
}
