using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Projection_Operators {
    class Program {

        class PetOwner {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }

        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();

            //Linq 6: This sample uses select to produce a sequence of ints one higher 
            //than those in an existing array of ints.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var incrNumbers = numbers.Select(n => n + 1);
            Console.WriteLine(string.Join(" ", incrNumbers));

            //SQL-like expression
            var incrNumbers2 = (from n in numbers
                                select n + 1);
            Console.WriteLine(string.Join(" ", incrNumbers2));

            //Linq 7: This sample uses select to return a sequence of just the names of a 
            //list of products.

            //{ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var productNames = products.Select(p => p.ProductName);
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            
            //Linq 8: This sample uses select to produce a sequence of strings representing the text 
            //version of a sequence of ints.
            var textNums = numbers.Select(n => strings[n]);
            Console.WriteLine(string.Join(" ",textNums));

            //Select - Anonymous Types
            //Linq 9: This sample uses select to produce a sequence of the uppercase and lowercase 
            //versions of each word in the original array.
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            foreach (var ul in upperLowerWords) {
                Console.WriteLine("Uppercase: {0}, Lowercaser: {1} ", ul.Upper, ul.Lower);
            }

            //Select - Anonymous Types
            //Linq 10: This sample uses select to produce a sequence containing text representations 
            //of digits and whether their length is even or odd.

            var digitOddEvens = numbers.Select(n => new { Digit = strings[n], Even = (n % 2 == 0) });
            foreach (var d in digitOddEvens) {
                Console.WriteLine("The digit {0} is {1}", d.Digit, d.Even ? "even" : "odd");
            }

            //sql-like expression:
            var digitOddEvens2 = from n in numbers
                                  select new { Digit = strings[n], Even = (n % 2 == 0) };
            foreach (var d in digitOddEvens2) {
                Console.WriteLine("The digit {0} is {1}", d.Digit, d.Even ? "even" : "odd");
            }

            //Select - Anonymous Types
            //Linq 11: This sample uses select to produce a sequence containing some properties of Products, 
            //including UnitPrice which is renamed to Price in the resulting type.

            var productInfos = products.Select(p =>
                    new { p.ProductName, p.CategoryID, Price = p.UnitPrice });

            //Select - Indexed
            //Linq 12: This sample uses an indexed Select clause to determine if the value of ints in an array 
            //match their position in the array.

            var numsInPlace = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });
            foreach (var n in numsInPlace) {
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
            }

            //SelectMany 
            //Linq 15: This sample uses a compound from clause to make a query that returns 
            //all pairs of numbers from both arrays such that the number from numbersA is 
            //less than the number from numbersB.

            int[] A = { 0, 2, 4, 5, 6, 8, 9 };
            int[] B = { 1, 3, 5, 7, 8 };

            //SQL-like approach
            var pairs = (from a in A
                         from b in B
                         where a < b
                         select new { a, b });
            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs) 
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);

            //Lambda-like approach
            var pairs2 = A.SelectMany(a => B, (a, b) => new { a, b })
                        .Where(pair => pair.a < pair.b).Select(pair => pair);
            foreach (var pair in pairs2)
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);

            //SelectMany with classes:
            //SQL-like approach
            var custOrders =
                    from c in customers
                    from o in orders
                    where o.OrderDate > new DateTime(1998, 1, 1)
                    select new { c.CompanyName, o.OrderID, o.OrderDate };
            foreach (var co in custOrders) {
                Console.WriteLine("{0}, {1}, {2}",co.CompanyName, co.OrderID,co.OrderDate);
            }
            Console.WriteLine(custOrders.Count()+" orders of all customers.");

            //Lambda-like approach
            var custOrders2 = customers.SelectMany(c => orders, (c, o)
                         => new { c.CompanyName, o.OrderID, o.OrderDate }).
                Where(o => o.OrderDate > new DateTime(1998, 1, 1));
            Console.WriteLine(custOrders2.Count() + " orders of all customers.");
        }
    }
}
