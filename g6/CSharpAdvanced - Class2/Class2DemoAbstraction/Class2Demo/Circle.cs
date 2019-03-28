using System;

namespace Class2Demo
{
    public class Circle : Shape
    {
        /// <summary>
        /// Overriding the base class method Draw, which is abstract.
        /// We need to provide an implentation for abstract method in derived class
        /// otherwise we will get compile time error.
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }
}
