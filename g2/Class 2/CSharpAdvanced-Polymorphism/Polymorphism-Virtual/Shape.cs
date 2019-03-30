using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Virtual
{
    class Shape
    {
        protected int width = 2;  //default value
        protected int height = 2; //default value
        public Shape() { }
        public Shape(int a, int b) { width = a; height = b; }
        public virtual double Area()
        {
            Console.WriteLine("Parent class area: ");
            return width * height;
        }
    }
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
    class Triangle : Shape
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
