using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;
using DataFromXml.Models;
using DataFromXml.Services;

namespace Element_Operators {
    class Program {
        static void Main(string[] args) {

            //load all the products, customers, orders
            List<Product> products = ProductService.GetAllProducts();
            List<Customer> customers = CustomerService.GetAllCustomers();
            List<Order> orders = OrderService.GetAllOrders();

            //Linq 58: This sample uses First to return the first matching element as a Product, 
            //instead of as a sequence containing a Product.
            //SQL-like solution
            Product product12 = (from p in products
                                 where p.ProductId == 12  //try with 122
                                 select p).First();
            
            //Lambda-like solution
            Product product_12 = products.Where(p => p.ProductId == 12).First();

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

            Product product789 = products.FirstOrDefault(p => p.ProductId == 789);
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

        }
    }
}
