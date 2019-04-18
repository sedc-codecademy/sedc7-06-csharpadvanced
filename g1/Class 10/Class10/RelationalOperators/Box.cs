using System;

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
            Console.WriteLine($"Width: {Width}, Height: {Height}, Length: {Length}");
        }


        #region Relational operators overloading
        //This == goes together with !=
        public static bool operator ==(Box a, Box b)
        {
            return b != null && a != null && a.Width == b.Width && a.Height == b.Height && a.Length == b.Length;
        }
        //This != goes together with ==
        public static bool operator !=(Box a, Box b)
        {
            return a != null && b != null && (a.Width != b.Width || a.Height != b.Height || a.Length != b.Length);
        }

        //This > goes together with <
        public static bool operator >(Box a, Box b)
        {
            return a.Width > b.Width && a.Height > b.Height && a.Length > b.Length;
        }
        //This < goes together with >
        public static bool operator <(Box a, Box b)
        {
            return a.Width < b.Width && a.Height < b.Height && a.Length < b.Length;
        }

        //This >= goes together with <=
        public static bool operator >=(Box a, Box b)
        {
            return a.Width >= b.Width && a.Height >= b.Height && a.Length >= b.Length;
        }
        //This <= goes together with >=
        public static bool operator <=(Box a, Box b)
        {
            return a.Width <= b.Width && a.Height <= b.Height && a.Length <= b.Length;
        }
        #endregion
    }
}
