using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using DataFromXml.Models;
using DataFromXml.Services;

namespace DataFromXml
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductService.GetAllProducts();
            var customers = CustomerService.GetAllCustomers();
            var orders = OrderService.GetAllOrders();

            ProductService.PrintProducts(products);
            CustomerService.PrintCustomers(customers);
            OrderService.PrintOrders(orders);


            var productsStartWithR = products.Where(x => x.ProductName.StartsWith("R")).Select(x => x).ToList();

            var productsStartWithR1 = from p in products
                                      where p.ProductName.StartsWith("R")
                                      select p;

            Console.ReadLine();
        }
    }
}
