using ShapingUpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUp.Shapes
{
    class Triangle : IShape
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle()
        {

        }

        public double GetArea()
        {
            double halfsize = GetPerimeter() / 2;
            double product = halfsize * (halfsize - FirstSide) * (halfsize - SecondSide) * (halfsize - ThirdSide);
            return Math.Sqrt(product);
        }

        public double GetPerimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
    }
}
