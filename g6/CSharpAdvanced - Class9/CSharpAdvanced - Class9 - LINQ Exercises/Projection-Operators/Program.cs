using System;
using System.Collections.Generic;
using System.Linq;
using DataFromXml;

namespace Projection_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //Use LINQ to produce a sequence of integers one higher 
            //than those in an existing array of integers
            //Both Lambda/SQL approach

            //Use LINQ to produce a sequence of strings representing the text 
            //version of a sequence of integers

            //Select - Anonymous Types
            //Use LINQto produce a sequence of the uppercase and lowercase 
            //versions of each word in the original array
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //Select - Anonymous Types
            //Linq 10: This sample uses select to produce a sequence containing text representations 
            //of digits and whether their length is even or odd.
            //Both Lambda/SQL approach

            //Select - Indexed
            //Use LINQ to determine if the value of ints in an array 
            //match their position in the array

            //SelectMany 
            //Use LINQ to make a query that returns 
            //all pairs of numbers from both arrays such that the number from numbersA is 
            //less than the number from numbersB
            //Both Lambda/SQL approach

            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };

            //Try to understand the scenario
            //SelectMany with classes:
            //SQL-like approach
            var custOrders =
                    from c in customers
                    from o in orders
                    where o.OrderDate > new DateTime(1998, 1, 1)
                    select new { c.CompanyName, o.OrderID, o.OrderDate };
            foreach (var co in custOrders)
            {
                Console.WriteLine("{0}, {1}, {2}", co.CompanyName, co.OrderID, co.OrderDate);
            }
            Console.WriteLine(custOrders.Count() + " orders of all customers.");

            //Lambda-like approach
            var custOrders2 = customers.SelectMany(c => orders, (c, o)
                         => new { c.CompanyName, o.OrderID, o.OrderDate }).
                Where(o => o.OrderDate > new DateTime(1998, 1, 1));
            Console.WriteLine(custOrders2.Count() + " orders of all customers.");
        }
    }
}