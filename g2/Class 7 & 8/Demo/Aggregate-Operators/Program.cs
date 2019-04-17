using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Aggregate_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Info

            #endregion
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 76,77,78,79,80: This sample uses Aggregate functions.  

            //Filter orders for CustomerID = VINET
            var vinetOrders = orders.Where(o => o.CustomerID == "VINET");
            foreach (var item in vinetOrders)
            {
                Console.WriteLine("Customer: {0}, ShipCity: {1}, Freight: {2}", item.CustomerID, item.ShipCity, item.Freight);
            }
            Console.WriteLine();

            //Linq 76: Returns the number of orders per each customer
            //         filter result for CustomerID =VINET
            #region Linq 76
            //var orderCounts = orders.GroupBy(o => o.CustomerID)
            //    .Select(g => new { Customer = g.Key, Count = g.Count() });
            //    //.Where(g => g.Customer == "VINET");

            //foreach (var item in orderCounts)
            //{
            //    Console.WriteLine("Customer {0}, Count {1}", item.Customer, item.Count);
            //}
            #endregion

            //Linq 77: Returns the number of orders per each customer and sum of Freight
            //         filter result for CustomerID =VINET
            #region Linq 77
            //var orderCountsAndSum = orders.GroupBy(o => o.CustomerID)
            //    .Select(g => new { Customer = g.Key, Count = g.Count(), Freight = g.Sum(p => p.Freight) })
            //    .Where(g => g.Customer == "VINET");

            //foreach (var item in orderCountsAndSum)
            //{
            //    Console.WriteLine("Customer: {0}, Count: {1}, Total freight: {2}",
            //        item.Customer, item.Count, item.Freight);
            //}
            #endregion

            //Linq 78: Returns Min freight of orders per each customer
            //         filter result for CustomerID = VINET
            #region Linq 78
            //var minOrderFreigh = orders.GroupBy(o => o.CustomerID)
            //    .Select(g => new { Customer = g.Key, MinFreight = g.Min(p => p.Freight) })
            //    .Where(g => g.Customer == "VINET");
            //foreach (var i in minOrderFreigh)
            //{
            //    Console.WriteLine("Customer: {0}, Min freight: {1}",
            //        i.Customer, i.MinFreight);
            //}
            #endregion

            //Linq 79: Returns Max freight of orders per each customer
            //         filter result for CustomerID = VINET
            #region Linq 79
            //var maxOrderFreigh = orders.GroupBy(o => o.CustomerID)
            //    .Select(g => new { Customer = g.Key, MaxFreight = g.Max(p => p.Freight) })
            //    .Where(g => g.Customer == "VINET");
            //foreach (var i in maxOrderFreigh)
            //{
            //    Console.WriteLine("Customer: {0}, Max freight: {1}",
            //        i.Customer, i.MaxFreight);
            //}
            #endregion

            //Linq 80: Returns Average freight of all orders
            #region Linq 80
            //var avgFreigthOfAll = orders.Average(o => o.Freight);
            //Console.WriteLine("The average freight is {0:F2}", avgFreigthOfAll);
            #endregion

            Console.ReadLine();
        }
    }
}
