using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Element_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Using SQL-like expression find the first Product with ProductID equals to 12 and more than 2 Units in Stock
            var product12 = (from p in products
                             where p.ProductID == 12 && p.UnitsInStock > 2
                             select p).FirstOrDefault();

            //Find all Products with more than 10 Units on Order and print the second one with more than 30 Units in Stock
            var productUnits10 = (from p in products
                                  where p.UnitsOnOrder == 10 && p.UnitsInStock > 30
                                  select p).Skip(1).Take(1).FirstOrDefault();

            //Using LINQ ElementAt method retrieve the second number greater than 5 from an array (both LAMBDA/SQL approach)
            int[] numbers = { 5, 4, 1, 2, 3, 6, 8, 7, 9, 0 };

            int secondGreaterThan5 = (from n in numbers
                                      where n > 5
                                      select n
                                      ).ElementAt(1);
            Console.WriteLine("Second number > 5: {0}", secondGreaterThan5);

            //lambda-like:
            int secondGreaterThenFive = numbers.Where(n => n > 5).ElementAt(1);
            Console.WriteLine("Second number > 5: {0}", secondGreaterThenFive);
        }
    }
}