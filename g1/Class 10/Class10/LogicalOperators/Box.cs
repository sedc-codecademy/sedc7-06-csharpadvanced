using System;

namespace LogicalOperators {
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

        #region Logical operators overloading
        public static bool operator &(Box a, Box b) {
            bool flag1 = !(a.Width == 0 && a.Height == 0 && a.Length == 0); //logical AND operation
            bool flag2 = !(b.Width == 0 && b.Height == 0 && b.Length == 0); //logical AND operation

            return flag1 & flag2; //bitwise AND operation
        }

        public static bool operator |(Box a, Box b) {
            bool flag1 = !(a.Width == 0 && a.Height == 0 && a.Length == 0); //logical AND operation
            bool flag2 = !(b.Width == 0 && b.Height == 0 && b.Length == 0); //logical AND operation

            return flag1 | flag2; //bitwise OR operation
        }

        public static bool operator ^(Box a, Box b) {
            bool flag1 = !(a.Width == 0 && a.Height == 0 && a.Length == 0); //logical AND operation
            bool flag2 = !(b.Width == 0 && b.Height == 0 && b.Length == 0); //logical AND operation

            return flag1 ^ flag2; //bitwise XOR operation
        }
        #endregion

    }
}
