using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // overload the constructor to create a fraction from a whole number
        public Fraction(int wholeNumber)
        {
            Console.WriteLine("In constructor taking a whole number");
            numerator = wholeNumber;
            denominator = 1;
        }
        // convert ints to Fractions implicitly
        public static implicit operator Fraction(int theInt)
        {
            Console.WriteLine("Implicitly converting int to Fraction");
            return new Fraction(theInt);
        }
        // convert Fractions to ints explicitly
        public static explicit operator int(Fraction theFraction)
        {
            Console.WriteLine("Explicitly converting Fraction to int");
            return theFraction.numerator / theFraction.denominator;
        }

        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            if (lhs.denominator == rhs.denominator)
            {
                return new Fraction(lhs.numerator + rhs.numerator, lhs.denominator);
            }
            // simplistic solution for unlike fractions
            // 1/2 + 3/4 == (1*4) + (3*2) / (2*4) == 10/8
            // this method does not reduce.

            int firstProduct = lhs.numerator * rhs.denominator;
            int secondProduct = rhs.numerator * lhs.denominator;
            return new Fraction(firstProduct + secondProduct,
            lhs.denominator * rhs.denominator);
        }
        public static bool operator ==(Fraction lhs, Fraction rhs)
        {
            //if (lhs.denominator == rhs.denominator && lhs.numerator == rhs.numerator)
            //{
            //    return true;
            //}
            //return false;

            if ((double)lhs.denominator / (double)rhs.denominator == (double)lhs.numerator / (double)rhs.numerator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fraction lhs, Fraction rhs)
        {
            return !(lhs == rhs);
        }
        public override bool Equals(object o)
        {
            if (!(o is Fraction))
            {
                return false;
            }
            return this == (Fraction)o;
        }
        public override int GetHashCode()
        {
            return numerator * denominator;
        }
        public override string ToString()
        {
            String s = numerator.ToString() + "/" + denominator.ToString();
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------- Fractions -----------");
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine("f1: {0}", f1.ToString());
            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2: {0}", f2.ToString());
            Fraction f3 = f1 + f2;
            Console.WriteLine("f1 + f2 = f3: {0}", f3.ToString());
            Fraction f4 = new Fraction(5, 4);
            if (f4 == f3)
            {
                Console.WriteLine("f4: {0} == F3: {1}", f4.ToString(), f3.ToString());
            }
            if (f4 != f2)
            {
                Console.WriteLine("f4: {0} != F2: {1}",
                f4.ToString(), f2.ToString());
            }
            if (f4.Equals(f3))
            {
                Console.WriteLine("{0}.Equals({1})",
                f4.ToString(), f3.ToString());
            }

            Console.WriteLine("adding f3 + 5...");
            Fraction f5 = f3 + 5;
            Console.WriteLine("f3 + 5 = f5: {0}", f5.ToString());
            Console.WriteLine("\nAssigning f5 to an int...");
            int truncated = (int)f5;
            Console.WriteLine("When you truncate f5 you get {0}", truncated);

            Console.ReadLine();
        }
    }
}
