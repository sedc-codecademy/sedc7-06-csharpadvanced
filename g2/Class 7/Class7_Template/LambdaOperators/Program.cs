using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace LambdaOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            Console.WriteLine("\nPress any key to print Products . . .");
            Console.ReadLine();
            Product.PrintProducts(products);
            Console.WriteLine("\nPress any key to print Customers . . .");
            Console.ReadLine();
            Customer.PrintCustomers(customers);
            Console.WriteLine("\nPress any key to print Orders . . .");
            Console.ReadLine();
            Order.PrintOrders(orders);

            Console.ReadLine();
        }
    }
}
