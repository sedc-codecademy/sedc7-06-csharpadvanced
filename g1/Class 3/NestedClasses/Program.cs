using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.AddOrderLine("Beer", 5, 30);
            order.AddOrderLine("Chips", 2, 90);
            Console.WriteLine("Total to pay: "+order.OrderTotal());  
        }
    }
}
