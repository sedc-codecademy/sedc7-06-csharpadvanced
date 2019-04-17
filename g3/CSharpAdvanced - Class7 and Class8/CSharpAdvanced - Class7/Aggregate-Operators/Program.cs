using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Aggregate_Operators {
    class Program {
        static void Main(string[] args) {
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 76,77,78,79,80: This sample uses Aggregate functions.  

            var vinetOrders = orders.Where(o => o.CustomerID == "VINET");
            foreach (var item in vinetOrders) {
                Console.WriteLine("Customer: {0}, Count: {1}, Freight: {2}", item.CustomerID, item.ShipCity,
                    item.Freight);
            }

            var orderCounts = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, Count = g.Count() })
                .Where(g => g.Customer =="VINET");

            foreach (var item in orderCounts) {
                Console.WriteLine("Customer {0}, Count {1}",item.Customer, item.Count);
            }

            var orderCountsAndSum = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, Count = g.Count(), Freight = g.Sum(p => p.Freight) })
                .Where(g => g.Customer == "VINET");

            foreach (var item in orderCountsAndSum) {
                Console.WriteLine("Customer: {0}, Count: {1}, Total freight: {2}",
                    item.Customer, item.Count, item.Freight);
            }

            var minOrderFreigh = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, MinFreight = g.Min(p => p.Freight) })
                .Where(g => g.Customer == "VINET");
            foreach (var i in minOrderFreigh) {
                Console.WriteLine("Customer: {0}, Min freight: {1}",
                    i.Customer, i.MinFreight);
            }

            var maxOrderFreigh = orders.GroupBy(o => o.CustomerID)
                .Select(g => new { Customer = g.Key, MaxFreight = g.Max(p => p.Freight) })
                .Where(g => g.Customer == "VINET");
            foreach (var i in maxOrderFreigh) {
                Console.WriteLine("Customer: {0}, Max freight: {1}",
                    i.Customer, i.MaxFreight);
            }

            var avgFreigthOfAll = orders.Average(o => o.Freight);
            Console.WriteLine("The average freight is {0:F2}", avgFreigthOfAll);

            var multiAggregate = orders.GroupBy(o => o.CustomerID)
                .Select(g => new {
                    Customer = g.Key,
                    Count = g.Count(),
                    MinFreight = g.Min(p => p.Freight),
                    MaxFreight = g.Max(p => p.Freight),
                    Average = g.Average(p => p.Freight),
                    Suma = g.Sum(p => p.Freight)
                });
            //.Where(g => g.Customer == "VINET");
            foreach (var i in multiAggregate) {
                Console.WriteLine("Customer: {0}, Count: {1}, Min freight: {2}, Max Freight {3}," +
                    " Average: {4}, Suma: {5} ",
                    i.Customer, i.Count, i.MinFreight, i.MaxFreight, i.Average, i.Suma);
            }
            
            //Count:
            var cnt = orders.Count; //property .Count
            var cnt2 = orders.Count(); // extension method Count()
            var cnt3 = orders.Count(o => o.OrderID > 0); // extension method Count()
            var cnt4 = orders.Count(o => o.ShipCountry.Length > 0);
            Console.WriteLine($"{cnt},{cnt2},{cnt3},{cnt4}");

        }
    }
}
