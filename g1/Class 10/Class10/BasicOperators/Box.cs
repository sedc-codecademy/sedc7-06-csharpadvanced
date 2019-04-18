using System;

namespace BasicOperators {
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

        public static Box operator +(Box a, Box b)
        {
            Box c = new Box
            {
                Width = a.Width + b.Width,
                Height = a.Height + b.Height,
                Length = a.Length + b.Length
            };
            return c;
        }

        public static Box operator -(Box a, Box b) {
            Box c = new Box
            {
                Width = a.Width - b.Width,
                Height = a.Height - b.Height,
                Length = a.Length - b.Length
            };
            return c;
        }
        
        public static Box operator -(Box a) {
            Box c = new Box
            {
                Width = -a.Width,
                Height = -a.Height,
                Length = -a.Length
            };
            return c;
        }

        public static Box operator *(Box a, Box b) {
            Box c = new Box
            {
                Width = a.Width * b.Width,
                Height = a.Height * b.Height,
                Length = a.Length * b.Length
            };
            return c;
        }

        public static Box operator /(Box a, Box b) {
            Box c = new Box
            {
                Width = a.Width / b.Width,
                Height = a.Height / b.Height,
                Length = a.Length / b.Length
            };
            return c;
        }

        public static Box operator %(Box a, Box b) {
            Box c = new Box
            {
                Width = a.Width % b.Width,
                Height = a.Height % b.Height,
                Length = a.Length % b.Length
            };
            return c;
        }

        public static Box operator ++(Box a) {
            Box c = new Box
            {
                Width = a.Width + 1,
                Height = a.Height + 1,
                Length = a.Length + 1
            };
            return c;
        }

        public static Box operator --(Box a) {
            Box c = new Box
            {
                Width = a.Width - 1,
                Height = a.Height - 1,
                Length = a.Length - 1
            };
            return c;
        }

        public static bool operator !(Box a) {
            return a.Width == 0 && a.Height == 0 && a.Length == 0;
        }

        public static Box operator +(Box a, int s)
        {
            var resultBox = new Box
            {
                Height = a.Height + s,
                Length = a.Length + s,
                Width = a.Width + s
            };
            return resultBox;
        }

    }
}
