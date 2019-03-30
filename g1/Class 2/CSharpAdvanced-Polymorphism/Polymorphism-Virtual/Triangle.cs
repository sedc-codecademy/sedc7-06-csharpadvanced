using System;

namespace Polymorphism_Virtual
{
    internal class Triangle : Shape
    {
        public Triangle() : base() { } //empty constructor inherits
        public Triangle(int a, int b) : base(a, b) { } //constructor inherits
        public override double Area()
        {
            Console.WriteLine("Triangle area: ");
            return (width * height / 2);
        }
    }
}