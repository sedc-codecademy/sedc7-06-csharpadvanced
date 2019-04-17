using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Set_Operators {
    class Program {
        
        static void Main(string[] args) {
            //load all the products, customer, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            void line() => Console.WriteLine();

            //Linq 46:
            //This sample uses Distinct to remove duplicate elements in a sequence of factors of 300.
            int[] factorsOf300 = { 2, 2, 3, 5, 5 }; 
            line(); 

            //Linq 47:Distinct to find the unique Category IDs. 

            line();

            //Linq 48: Union to create one sequence that contains the unique values from both arrays.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var uniqueNumbers = numbersA.Union(numbersB); 

            line();
            //Linq 49: Union to create one sequence that contains the unique first letter 
            //from both product and customer names. Union()

            var prodFirstChars = products.Select(p => p.ProductName[0]);
            var custFirstChars = customers.Select(c => c.CompanyName[0]); 

            //Linq 51: Intersect to create one sequence that contains the common first letter 
            //from both product and customer names. 
            line();

            //Linq 50: Intersect to create one sequence that contains the common values shared by both arrays.
            Console.WriteLine("----------------");
            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 }; 
            line();
            Console.WriteLine("----------------");
            //Linq 52: Except to create a sequence that contains the values from numbers A that 
            // are not also in numbers B. 

        }

    }
}
