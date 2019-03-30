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

        /// <summary>
        /// Makes the following checks
        /// 1. a+b > c
        /// 2. a+c > b
        /// 3. b+c > a
        /// 4. a > 0
        /// 5. b > 0
        /// 6. c > 0
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <returns></returns>
        public static bool IsValidTriangle(double firstSide, double secondSide, double thirdSide)
        {
            Console.WriteLine("Validating");
            if (firstSide <= 0)
            {
                return false;
            }
            if (secondSide <= 0)
            {
                return false;
            }
            if (thirdSide <= 0)
            {
                return false;
            }
            if (firstSide + secondSide < thirdSide)
            {
                return false;
            }
            if (firstSide + thirdSide < secondSide)
            {
                return false;
            }
            if (secondSide + thirdSide < firstSide)
            {
                return false;
            }
            return true;
        }

        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsValidTriangle(firstSide, secondSide, thirdSide))
            {
                throw new ApplicationException($"The sides {firstSide}, {secondSide} and {thirdSide} do not construct a valid triangle");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
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

    //public class TriangleValidator
    //{
    //    /// <summary>
    //    /// Makes the following checks
    //    /// 1. a+b > c
    //    /// 2. a+c > b
    //    /// 3. b+c > a
    //    /// 4. a > 0
    //    /// 5. b > 0
    //    /// 6. c > 0
    //    /// </summary>
    //    /// <param name="firstSide"></param>
    //    /// <param name="secondSide"></param>
    //    /// <param name="thirdSide"></param>
    //    /// <returns></returns>
    //    public bool IsValidTriangle(double firstSide, double secondSide, double thirdSide)
    //    {
    //        Console.WriteLine("Validating");
    //        if (firstSide <= 0)
    //        {
    //            return false;
    //        }
    //        if (secondSide <= 0)
    //        {
    //            return false;
    //        }
    //        if (thirdSide <= 0)
    //        {
    //            return false;
    //        }
    //        if (firstSide + secondSide < thirdSide)
    //        {
    //            return false;
    //        }
    //        if (firstSide + thirdSide < secondSide)
    //        {
    //            return false;
    //        }
    //        if (secondSide + thirdSide < firstSide)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //}


}
