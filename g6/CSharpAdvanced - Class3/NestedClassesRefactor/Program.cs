using NestedClassesRefactor.MyClasses;
using System;

namespace NestedClassesRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.AddOrderLine("Beer", 5, 30);
            order.AddOrderLine("Chips", 2, 90);
            Console.WriteLine("Total to pay: " + order.OrderTotal());
        }
    }
}