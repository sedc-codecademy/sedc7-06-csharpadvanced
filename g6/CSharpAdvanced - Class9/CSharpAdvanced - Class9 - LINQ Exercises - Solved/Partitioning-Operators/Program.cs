using DataFromXml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Partitioning_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load all the Products, Customers, Orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Get only the first 3 elements of the array and order from highest to lowest
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Get the first 10 orders from customers in London
            //Both LAMBDA/SQL approach)
            var first3LondonCustomers = customers.Where(c => c.City == "London").Take(3);
            Customer.PrintCustomers(first3LondonCustomers);

            first3LondonCustomers = (from c in customers
                                     where c.City == "London"
                                     select c
                                         ).Take(3);
            Customer.PrintCustomers(first3LondonCustomers);

            //Get all but the first Order from Customers in 'Rio de Janeiro'
            var allButFirstOneRio = customers.Where(c => c.City == "Rio de Janeiro").Skip(1);
            Customer.PrintCustomers(allButFirstOneRio);

            //Use LINQ Take While method to return elements starting from the beginning of the array 
            //until a number is hit that is not less than 6
            var firstNumsLessThan6 = numbers.TakeWhile(n => n < 6);
            Console.WriteLine("First less than 6: {0}", string.Join(" ", firstNumsLessThan6));

            //Use LINQ Take While method to return elements starting from the beginning of the array
            //until a number is hit that is less than its position in the array.
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            Console.WriteLine("First numbers not less than their position: {0}",
                string.Join(" ", firstSmallNumbers));

            //Use LINQ Skip While method to get the elements of the array starting from the first 
            //element divisible by 3.
            var allNotDivisibleBy3 = numbers.SkipWhile(n => n % 3 != 0);
            Console.WriteLine("All numbers not divisible by 3: {0}",
                string.Join(" ", allNotDivisibleBy3));

            //Use LINQ Skip While to get the elements of the array starting from the first element less 
            //than its position.
            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
            Console.WriteLine("Skip first numbers greater then their position: {0}",
                string.Join(" ", laterNumbers));
        }
    }
}