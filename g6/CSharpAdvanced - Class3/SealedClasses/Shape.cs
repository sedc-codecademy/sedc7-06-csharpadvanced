using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    /// <summary>
    ///  Sealed modifier prevents derivation of classes or overriding methods
    ///  Here in our example for Shape, we use Shape as a base class. You can 
    ///  try and put "sealed" modifier and you will see that class Triangle
    ///  will not have a chance to inherit from Shape.
    ///  It will be something like, public sealed class Shape, I am not
    ///  typing it directly just to avoid compile time error, but you can try 
    ///  yourself and you will see that you will get immediately a compile time 
    ///  error, saying that you cannot inherit from a sealed class...
    /// </summary>
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }

        public Shape()
        {

        }

        public Shape(int height, int width, string color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        /// <summary>
        /// Virtual method that can be redefined in derived classes. In our example we dont have 
        /// any implementation inside. 
        /// </summary>
        public virtual void Draw()
        {
        }
    }
}
