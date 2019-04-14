using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Restriction_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            Action line = () => Console.WriteLine();

            //Linq 1: find all elements of an array less than 5.
            #region Linq 1 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10, -12, -14 };
            //var lowNumbers = from n in numbers
            //                 where n < 5
            //                 select n;
            //Console.WriteLine("Linq1: " + string.Join(" ", lowNumbers.ToArray()));
            //line();
            //var lowNumbers2 = numbers.Where(n => n < 5);
            //Console.WriteLine("Linq1: " + string.Join(" ", lowNumbers2.ToArray()));
            #endregion

            //Linq 2: find all products that are out of stock
            #region Linq 2
            //var soldOutProducts = products.Where(p => p.UnitsInStock == 0);
            //Product.PrintProducts(soldOutProducts);
            //line();
            //var soldOutProducts2 = from p in products
            //                       where p.UnitsInStock == 0
            //                       select p;
            //Product.PrintProducts(soldOutProducts2);
            #endregion

            //Linq 3: find all products that are in stock and cost more than 3.00 per unit.
            #region Linq 3
            //var expensiveInStockProducts = from p in products
            //                               where p.UnitsInStock > 100 && p.UnitPrice > 3.0
            //                               select p;
            //Product.PrintProducts(expensiveInStockProducts);
            //line();
            //var expensiveInStockProducts2 = products.Where(p => p.UnitsInStock > 100 && p.UnitPrice > 3.0);
            //Product.PrintProducts(expensiveInStockProducts2);
            #endregion

            //Linq 4: This sample uses where to find all customers in Berlin and then uses 
            //        the resulting sequence to drill down into their orders.
            #region Linq 4
            //var berlinCustomers = from c in customers
            //                      where c.City == "Berlin"
            //                      select c;
            //Console.WriteLine("Customers from Berlin and their orders:");
            //foreach (var cust in berlinCustomers)
            //{
            //    Console.WriteLine("Customer {0}: {1}", cust.CustomerID, cust.CompanyName);
            //    var custOrders = from o in orders
            //                     where o.CustomerID == cust.CustomerID
            //                     select o;
            //    Order.PrintOrders(custOrders);
            //}
            //line();
            //var berlinCustomers2 = customers.Where(c => c.City == "Berlin");
            //Console.WriteLine("Customers from Berlin and their orders:");
            //foreach (var cust in berlinCustomers2)
            //{
            //    Console.WriteLine("Customer {0}: {1}", cust.CustomerID, cust.CompanyName);
            //    var custOrders = orders.Where(o => o.CustomerID == cust.CustomerID);

            //    Order.PrintOrders(custOrders);
            //}
            #endregion

            Console.ReadLine();
        }

    }
}
