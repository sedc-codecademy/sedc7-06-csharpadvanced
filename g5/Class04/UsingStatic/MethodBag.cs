using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStatic
{
    static class MethodBag
    {
        public static double Double(double number)
        {
            return number * 2;
        }

        public class ComplexNumber
        {
            public double Real { get; set; }
            public double Imaginary { get; set; }

            public override string ToString()
            {
                return $"{Real}+i{Imaginary}";
            }
        }

        
    }
}
