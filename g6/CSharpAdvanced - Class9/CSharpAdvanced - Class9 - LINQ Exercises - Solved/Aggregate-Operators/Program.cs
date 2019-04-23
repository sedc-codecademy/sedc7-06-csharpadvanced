using System;
using System.Collections.Generic;
using System.Linq;
using DataFromXml;

namespace Aggregate_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Find all orders with 'VINET' Customer ID and print information for Count and Freight
            var vinetOrders = orders.Where(o => o.CustomerID == "VINET");
            foreach (var item in vinetOrders)
            {
                Console.WriteLine("Customer: {0}, Count: {1}, Freight: {2}", item.CustomerID, item.ShipCity,
                    item.Freight);
            }

            //Print the count of all orders per different Customer ID
            var orderCounts = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, Count = g.Count() })
                .Where(g => g.Customer == "VINET");

            foreach (var item in orderCounts)
            {
                Console.WriteLine("Customer {0}, Count {1}", item.Customer, item.Count);
            }

            //Print the count and total Freight of all orders with 'VINET' Customer ID
            var orderCountsAndSum = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, Count = g.Count(), Freight = g.Sum(p => p.Freight) })
                .Where(g => g.Customer == "VINET");

            foreach (var item in orderCountsAndSum)
            {
                Console.WriteLine("Customer: {0}, Count: {1}, Total freight: {2}",
                    item.Customer, item.Count, item.Freight);
            }

            //Print the order with 'VINET' Customer ID identified by the minimal Freight
            var minOrderFreigh = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, MinFreight = g.Min(p => p.Freight) })
                .Where(g => g.Customer == "VINET");
            foreach (var i in minOrderFreigh)
            {
                Console.WriteLine("Customer: {0}, Min freight: {1}",
                    i.Customer, i.MinFreight);
            }

            //Print all orders per different Ship Country identified by the maximum Freight
            var maxOrderFreighByShipCountries = orders.GroupBy(o => o.ShipCountry)
                .Select(g => new { Customer = g.Key, MaxFreight = g.Max(p => p.Freight) });
            foreach (var i in maxOrderFreighByShipCountries)
            {
                Console.WriteLine("Customer: {0}, Max freight: {1}",
                    i.Customer, i.MaxFreight);
            }

            //Print the average Freight (with two decimals) for all orders
            var avgFreigthOfAll = orders.Average(o => o.Freight);
            Console.WriteLine("The average freight is {0:F2}", avgFreigthOfAll);
        }
    }
}