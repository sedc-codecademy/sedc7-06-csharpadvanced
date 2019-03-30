using ShapingUpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUp.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        /// <summary>
        /// Creates a circle with the specified radius. Throws ApplicationException if radius is zero or negative
        /// </summary>
        /// <exception cref="ApplicationException">
        /// </exception>
        /// <param name="radius">The radius of the created circle</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ApplicationException("Circle radius cannot be zero or negative");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
