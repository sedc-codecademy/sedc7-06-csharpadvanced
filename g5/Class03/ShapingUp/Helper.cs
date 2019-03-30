using ShapingUpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUp
{
    static class Helper
    {
        public static double GetAverageArea(this ShapeCollection shapes)
        {
            int count = shapes.Count();
            double area = shapes.TotalArea();
            double result = area / count;
            return result;
        }

        public static double GetAveragePerimeter(this ShapeCollection shapes)
        {
            int count = shapes.Count();
            double area = shapes.TotalPerimeter();
            double result = area / count;
            return result;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static int Double(this int number)
        {
            return number * 2;
        }

        public static int Square(this int number)
        {
            return number * number;
        }

        public static int AddOne(this int number)
        {
            return number + 1;
        }


    }
}
