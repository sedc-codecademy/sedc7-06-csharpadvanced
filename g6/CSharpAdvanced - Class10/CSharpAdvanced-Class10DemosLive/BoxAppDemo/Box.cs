using System;

namespace BoxAppDemo
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
    }
}
