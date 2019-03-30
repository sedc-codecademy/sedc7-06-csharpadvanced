using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUpLib
{
    public interface IShape
    {
        double GetArea();

        double GetPerimeter();
    }

    public static class IShapeHelper
    {
        public static double GetRatio(this IShape shape)
        {
            var area = shape.GetArea();
            var perimeter = shape.GetPerimeter();
            return area / perimeter;
        }
    }


}
