using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalOperators {
    public class Box {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public Box() { }
        public Box(int width, int height, int length) {
            Width = width; Height = height; Length = length;
        }

        public int Volume() {
            return Width * Height * Length;
        }

        public void PrintBox() {
            Console.WriteLine($"Width: {this.Width}, Height: {this.Height}, Length: {this.Length}");
        }

        #region Basic operators overloading
        public static Box operator +(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width + b.Width;
            c.Height = a.Height + b.Height;
            c.Length = a.Length + b.Length;
            return c;
        }

        //subtruction
        public static Box operator -(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width - b.Width;
            c.Height = a.Height - b.Height;
            c.Length = a.Length - b.Length;
            return c;
        }
        //negation
        public static Box operator -(Box a) {
            Box c = new Box();
            c.Width = -a.Width;
            c.Height = -a.Height;
            c.Length = -a.Length;
            return c;
        }

        public static Box operator *(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width * b.Width;
            c.Height = a.Height * b.Height;
            c.Length = a.Length * b.Length;
            return c;
        }

        public static Box operator /(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width / b.Width;
            c.Height = a.Height / b.Height;
            c.Length = a.Length / b.Length;
            return c;
        }

        public static Box operator %(Box a, Box b) {
            Box c = new Box();
            c.Width = a.Width % b.Width;
            c.Height = a.Height % b.Height;
            c.Length = a.Length % b.Length;
            return c;
        }

        public static Box operator ++(Box a) {
            Box c = new Box();
            c.Width = a.Width + 1;
            c.Height = a.Height + 1;
            c.Length = a.Length + 1;
            return c;
        }

        public static Box operator --(Box a) {
            Box c = new Box();
            c.Width = a.Width - 1;
            c.Height = a.Height - 1;
            c.Length = a.Length - 1;
            return c;
        }
        #endregion


        #region Relational operators overloading
        //This == goes together with !=
        public static bool operator ==(Box a, Box b) {
            return (a.Width == b.Width && a.Height == b.Height && a.Length == b.Length);
        }
        //This != goes together with ==
        public static bool operator !=(Box a, Box b) {
            return (a.Width == b.Width && a.Height == b.Height && a.Length == b.Length);
        }

        //This > goes together with <
        public static bool operator >(Box a, Box b) {
            return (a.Width > b.Width && a.Height > b.Height && a.Length > b.Length);
        }
        //This < goes together with >
        public static bool operator <(Box a, Box b) {
            return (a.Width < b.Width && a.Height < b.Height && a.Length < b.Length);
        }

        //This >= goes together with <=
        public static bool operator >=(Box a, Box b) {
            return (a.Width >= b.Width && a.Height >= b.Height && a.Length >= b.Length);
        }
        //This <= goes together with >=
        public static bool operator <=(Box a, Box b) {
            return (a.Width <= b.Width && a.Height <= b.Height && a.Length <= b.Length);
        }
        #endregion


    }
}
