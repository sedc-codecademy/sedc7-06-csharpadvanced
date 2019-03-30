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
}
