using System;

namespace Class2Demo
{
    public class Circle : Shape
    {
        /// <summary>
        /// We provide an implementation for the base class virtual method "Draw"
        /// for drawing a circle. We do that with override keyword
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }
}
