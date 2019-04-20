using System;

namespace BoxOperatorsOverloading
{
    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Box()
        {

        }
        public Box(int length, int width, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
        public int Volume()
        {
            return Length * Width * Height;
        }
        public void PrintBox()
        {
            Console.WriteLine($"Length: {this.Length}, Width: {this.Width}, Height: {this.Height}");
        }

        #region BasicOperators
        public static Box operator +(Box a)
        {
            a.Length = +a.Length;
            a.Width = +a.Width;
            a.Height = +a.Height;
            return a;
        }
        public static Box operator -(Box a)
        {
            a.Length = -a.Length;
            a.Width = -a.Width;
            a.Height = -a.Height;
            return a;
        }
        public static Box operator ++(Box a)
        {
            a.Length++;
            a.Width++;
            a.Height++;
            return a;
        }
        public static Box operator --(Box a)
        {
            a.Length--;
            a.Width--;
            a.Height--;
            return a;
        }
        public static bool operator !(Box a)
        {
            return (a.Length == 0 && a.Width == 0 && a.Height == 0);
        }

        public static Box operator +(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length + b.Length;
            c.Width = a.Width + b.Width;
            c.Height = a.Height + b.Height;
            return c;
        }
        public static Box operator -(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length - b.Length;
            c.Width = a.Width - b.Width;
            c.Height = a.Height - b.Height;
            return c;
        }
        public static Box operator *(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length * b.Length;
            c.Width = a.Width * b.Width;
            c.Height = a.Height * b.Height;
            return c;
        }
        public static Box operator /(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length / b.Length;
            c.Width = a.Width / b.Width;
            c.Height = a.Height / b.Height;
            return c;
        }
        public static Box operator %(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length % b.Length;
            c.Width = a.Width % b.Width;
            c.Height = a.Height % b.Height;
            return c;
        }
        #endregion

        #region RelationalOperators
        //== goes together with !=
        public static bool operator ==(Box a, Box b)
        {
            return (a.Length == b.Length && a.Width == b.Width && a.Height == b.Height);
        }
        public static bool operator !=(Box a, Box b)
        {
            return !(a == b);
        }
        //> goes together with <
        public static bool operator >(Box a, Box b)
        {
            return (a.Length > b.Length && a.Width > b.Width && a.Height > b.Height);
        }
        public static bool operator <(Box a, Box b)
        {
            return (a.Length < b.Length && a.Width < b.Width && a.Height < b.Height);
        }
        //>= goes together with <=
        public static bool operator >=(Box a, Box b)
        {
            return (a.Length >= b.Length && a.Width >= b.Width && a.Height >= b.Height);
        }
        public static bool operator <=(Box a, Box b)
        {
            return (a.Length <= b.Length && a.Width <= b.Width && a.Height <= b.Height);
        }
        #endregion

        #region LogicalOperators
        public static Box operator &(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length & b.Length;
            c.Width = a.Width & b.Width;
            c.Height = a.Height & b.Height;
            return c;
        }
        public static Box operator |(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length | b.Length;
            c.Width = a.Width | b.Width;
            c.Height = a.Height | b.Height;
            return c;
        }
        public static Box operator ^(Box a, Box b)
        {
            Box c = new Box();
            c.Length = a.Length ^ b.Length;
            c.Width = a.Width ^ b.Width;
            c.Height = a.Height ^ b.Height;
            return c;
        }
        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- ++b1 Operator -----------");
            //++b1;
            //b1.PrintBox();

            //Console.WriteLine("\n----------- --b1 Operator -----------");
            //--b1;
            //b1.PrintBox();

            //int x = -5;
            //int y = 10;
            //y = -x;
            //Console.WriteLine($"x: {x}, y: {y}");

            //Console.WriteLine("\n----------- !b1 Operator -----------");
            //Console.WriteLine($"! Operator: {!b1}");

            //Console.WriteLine("\n----------- b1 + b2 Operator -----------");
            //Box b3 = b1 + b2;
            //b3.PrintBox();

            //Console.WriteLine("\n----------- b1 - b2 Operator -----------");
            //Box b4 = b1 - b2;
            //b4.PrintBox();

            //Console.WriteLine("\n----------- b1 * b2 Operator -----------");
            //Box b5 = b1 * b2;
            //b5.PrintBox();

            //Console.WriteLine("\n----------- b1 / b2 Operator -----------");
            //Box b6 = b1 / b2;
            //b6.PrintBox();

            //Console.WriteLine("\n----------- b1 % b2 Operator -----------");
            //Box b7 = b1 % b2;
            //b7.PrintBox();

            //Console.ReadLine();
            #endregion

            #region LogicalOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- b1 & b2 Operator -----------");
            //Box b3 = b1 & b2;
            //b3.PrintBox();

            //Console.WriteLine("\n----------- b1 | b2 Operator -----------");
            //Box b4 = b1 | b2;
            //b4.PrintBox();

            //Console.WriteLine("\n----------- b1 ^ b2 Operator -----------");
            //Box b5 = b1 ^ b2;
            //b5.PrintBox();

            //Console.ReadLine();
            #endregion

            #region RelationalOperators
            //Console.WriteLine("----------- Box b1 -----------");
            //Box b1 = new Box(5, 5, 5);
            //b1.PrintBox();

            //Console.WriteLine("----------- Box b2 -----------");
            //Box b2 = new Box(3, 3, 3);
            //b2.PrintBox();

            //Console.WriteLine("\n----------- b1 == b2 Operator -----------");
            //Console.WriteLine($"b1 == b2: {b1 == b2}");

            //Console.WriteLine("\n----------- b1 != b2 Operator -----------");
            //Console.WriteLine($"b1 != b2: {b1 != b2}");

            //Console.WriteLine("\n----------- b1 > b2 Operator -----------");
            //Console.WriteLine($"b1 > b2: {b1 > b2}");

            //Console.WriteLine("\n----------- b1 < b2 Operator -----------");
            //Console.WriteLine($"b1 < b2: {b1 < b2}");

            //Console.WriteLine("\n----------- b1 >= b2 Operator -----------");
            //Console.WriteLine($"b1 >= b2: {b1 >= b2}");

            //Console.WriteLine("\n----------- b1 <= b2 Operator -----------");
            //Console.WriteLine($"b1 <= b2: {b1 <= b2}");

            //Console.ReadLine();
            #endregion
        }
    }
}