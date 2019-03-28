using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Static
{
    public class PrintData
    {
        public void Print(int i)
        { Console.WriteLine("Printing int: {0}", i); }

        public void Print(double d)
        { Console.WriteLine("Printing double: {0}", d); }

        public void Print(string s)
        { Console.WriteLine("Printing string: {0}", s); }

        public void Print(int i, double d)
        { Console.WriteLine("Integer {0}, Double {1:F2}", i, d); }

        public void Print(decimal d, int i)
        { Console.WriteLine("Decimal {1:F2}, Integer {0}", d, i); }

        public void Print(float f, long i)
        { Console.WriteLine("Float {1:F2}, Long integer {0}", f, i); }

        //Homework: Extend the PrintData class for 5 new data types.
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Polymorphism AdHoc or Static ---");
            PrintData p = new PrintData();
            p.Print(100);
            p.Print(100.0);
            p.Print("Sto");
            p.Print((int)100, (double)100);
            p.Print(100, 100.0);
            p.Print(100.05M, 100);
            p.Print( 100.02F,  100L);
            Console.ReadLine();
        }
    }
}
