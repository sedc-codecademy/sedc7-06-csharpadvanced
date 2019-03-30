using System;

namespace Polymorphism_Virtual
{
    class Rectangle : Shape
    {
        public Rectangle() : base() { } //empty constructor inherits
        public Rectangle(int a, int b) : base(a, b) { } //constructor inherits
        public override double Area()
        {
            Console.WriteLine("Rectangle class area: ");
            return (height * width);
        }
    }
}