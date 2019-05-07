using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowExample
{
    class Rectangle
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public int Area {
            get
            {
                return Width * Height;
            }
        }

        public void Squish()
        {
            Height = Height / 2;
            Width = Width * 2;
        }
    }
}
