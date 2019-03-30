using ShapingUpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUp.Shapes
{
    class Square : IShape
    {
        public double Side { get; private set; }

        public static bool IsValid(double side)
        {
            if (side <= 0)
            {
                return false;
            }
            return true;
        }

        public Square(double side)
        {
            if (!IsValid(side))
            {
                throw new ApplicationException("The side cannot be zero or negative");
            }
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
