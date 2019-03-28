using System;

namespace Class2Demo
{
    /// <summary>
    /// New type of shape called rectangle, we are inheriting the functionalities
    /// provided by the base class Shape
    /// </summary>
    public class Rectrangle : Shape
    {
        /// <summary>
        /// We provide an implementation for the base class method "Draw"
        /// for drawing a rectangle. We do that with override keyword
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Draw a rectrangle.");
        }
    }
}
