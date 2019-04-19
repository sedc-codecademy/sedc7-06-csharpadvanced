using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
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
}
