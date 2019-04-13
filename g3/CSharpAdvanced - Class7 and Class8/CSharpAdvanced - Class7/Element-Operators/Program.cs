using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Element_Operators {
    class Program {
        static void Main(string[] args) {

            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 58: This sample uses First to return the first matching element as a Product, 
            //instead of as a sequence containing a Product.
            //SQL-like solution
            Product product12 = (from p in products
                                 where p.ProductID == 12  //try with 122
                                 select p).First();
            
            //Lambda-like solution
            Product product_12 = products.Where(p => p.ProductID == 12).First();

            //product12.PrintProduct(product12);
            //product_12.PrintProduct(product_12);

            //Linq 59: This sample uses First to find the first element in the array that starts with 't'.
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string startsWithT = strings.First(s => s[0] == 't');
            Console.WriteLine("A string starting with 't': {0}", startsWithT);

            //Linq 61: This sample uses FirstOrDefault to try to return the first element of the sequence, 
            //unless there are no elements, in which case the default value for that type is returned.

            int[] numbers = { }; //empty array
            int firstNumOrDefault = numbers.FirstOrDefault();
            Console.WriteLine(firstNumOrDefault);

            //Linq 62: This sample uses FirstOrDefault to return the first product whose ProductID is 789 
            //as a single Product object, unless there is no match, in which case null is returned.

            Product product789 = products.FirstOrDefault(p => p.ProductID == 789);
            Console.WriteLine("Product 789 exists: {0}",product789 != null);

            //Linq 64: This sample uses ElementAt to retrieve the second number greater than 5 from an array.
            //sql-like:
            int[] numbers2 = { 5, 4, 1, 2, 3, 6, 8, 7, 9, 0 };
            int secondGreaterThan5 = (from n in numbers2
                                      where n > 5
                                      select n
                                      ).ElementAt(1);
            Console.WriteLine("Second number > 5: {0}", secondGreaterThan5);
            
            //lambda-like:
            int secondGreaterThenFive = numbers2.Where(n => n > 5).ElementAt(1);
            Console.WriteLine("Second number > 5: {0}", secondGreaterThenFive);


            //Single and Last

            string[] items = new string[] { "Zero", "One", "Zero", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            string[] single = new string[] { "One Item" };

            //var s1 = items.SingleOrDefault(x => x == "Zero");
            //Console.WriteLine(s1);

            var singl = items.SingleOrDefault(s => s == "Zero2");
            Console.WriteLine(singl);

            var last = items.Last();
            Console.WriteLine(last);

            last = items.LastOrDefault(s => s == "eleven");
            //Console.WriteLine(last);
            //Console.ReadKey();

            string[] prazna = { "one" };
            var sngl = prazna.Single(s => s == "one");
            Console.WriteLine(sngl);

            Console.ReadKey();

            //var p1 = prazna.Last();
            //Console.WriteLine(p1);
            //var p2 = prazna.LastOrDefault();
            //Console.WriteLine(p2);

            //var one = items.Single(i => i.StartsWith("T")); //fails
            //Console.WriteLine(one);

            //var one2 = items.SingleOrDefault(i => i.StartsWith("Z"));
            //Console.WriteLine(one2);

            var cust = customers.Single(c => c.CustomerID == "ALFKI");
            Console.WriteLine(cust.CustomerID + " " + cust.ContactName);

            Console.ReadKey();

            //cust = customers.SingleOrDefault(c => c.CustomerID == "ALFKI2");
            //Console.WriteLine(cust.CustomerID + " " + cust.ContactName);

            /*
             Points to Remember :
                Single() expects one and only one element in the collection.
                Single() throws an exception when it gets no element or more than one elements in the collection.
                If specified a condition in Single() and result contains no element or more than one elements then 
                it throws an exception.
                SingleOrDefault() will return default value of a data type of generic collection if there is no elements 
                in a colection or for the specified condition.
                SingleOrDefault() will throw an exception if there is more than one elements in a colection or for the 
                specified condition.
             */

        }
    }
}
