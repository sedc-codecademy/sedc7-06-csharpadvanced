using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;
using DataFromXml.Models;
using DataFromXml.Services;

namespace Restriction_Operators {
    class Program {
        static void Main(string[] args) {

            //load all the products, customers, orders
            List<Product> products = ProductService.GetAllProducts();
            List<Customer> customers = CustomerService.GetAllCustomers();
            List<Order> orders = OrderService.GetAllOrders();

            Action line = () => Console.WriteLine();

            //Linq 1: find all elements of an array less than 5. 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10, -12, -14 };

            //solution1 with SQL-like LINQ:
            var lowNumbers = from n in numbers
                             where n < 5
                             select n;
            //Console.WriteLine("Linq1: " + string.Join(" ", lowNumbers.ToArray()));
            
            //solution2 with Lambda expression:
            var lowNumbers2 = numbers.Where(n => n < 5);
            //Console.WriteLine("Linq1: " + string.Join(" ", lowNumbers2.ToArray())); 

            //Linq 2: find all products that are out of stock
            var soldOutProducts = products.Where(p => p.UnitsInStock == 0);
            var soldOutProducts2 = from p in products
                                   where p.UnitsInStock == 0
                                   select p;
            //Product.PrintProducts(soldOutProducts);

            //Linq 3: find all products that are in stock and cost more than 3.00 per unit.

            var expensiveInStockProducts = from p in products
                                           where p.UnitsInStock > 0 && p.UnitPrice > 3.0
                                           select p;
            var expensiveInStockProducts2 = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.0);
            //Product.PrintProducts(expensiveInStockProducts2);

            /*
             Linq 4: This sample uses where to find all customers in Berlin and then uses 
                     the resulting sequence to drill down into their orders.
            */
            //load all customers            

            //sql-like approach:
            var berlinCustomers = from c in customers
                              where c.City == "Berlin"
                              select c;
            Console.WriteLine("Customers from Berlin and their orders:");
            foreach (var cust in berlinCustomers) {
                Console.WriteLine("Customer {0}: {1}",cust.CustomerId, cust.CompanyName);
                var custOrders = from o in orders
                                 where o.CustomerId == cust.CustomerId
                                 select o;
                OrderService.PrintOrders(custOrders);
            }

            line();

            var berlinCustomers2 = customers.Where(c => c.City == "Berlin");
            Console.WriteLine("Customers from Berlin and their orders:");
            foreach (var cust in berlinCustomers2) {
                Console.WriteLine("Customer {0}: {1}", cust.CustomerId, cust.CompanyName);
                var custOrders = orders.Where(o => o.CustomerId == cust.CustomerId);

                OrderService.PrintOrders(custOrders);
            }

            //Linq 5: This sample demonstrates an indexed Where clause that returns digits whose 
            // name is shorter than their value

            line();

            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in shortDigits) {
                Console.WriteLine("The length of the word '{0}' is shorter than its value.", d);
            }

        }

    }
}
