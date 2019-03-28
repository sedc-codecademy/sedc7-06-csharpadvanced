using System;

namespace Class2Demo
{
    public class Rectrangle : Shape
    {
        /// <summary>
        /// We need to provide implementation for the abstract method Draw() from the base class,
        /// if we dont provide implementation we will get compile time error.
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Draw a rectrangle.");
        }
    }
}
