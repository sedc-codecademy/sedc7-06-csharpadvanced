using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;

namespace Join_Operators {
    class Program {
        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = Product.GetAllProducts();
            List<Customer> customers = Customer.GetAllCustomers();
            List<Order> orders = Order.GetAllOrders();
            
            //Linq 102: This sample shows how to efficiently join elements of two sets based on equality 
            //between key expressions over the two. Additinally filetring is done with a Where clause.
            //sql-like query:
            var q =
                from c in customers
                join o in orders on c.CustomerID equals o.CustomerID
                where c.CustomerID == "VINET"
                select new { Customer = c.CustomerID, City = o.ShipCity, o.Freight };

            foreach (var item in q) {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}",item.Customer, item.City, item.Freight);
            }

            //lambda-like query:
            var q2 = customers.Join(orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new { Customer = c.CustomerID, City = o.ShipCity, Freight = o.Freight, Employee = o.EmployeeID })
                .Where(c => c.Customer == "VINET");
            foreach (var item in q2) {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}", item.Customer, item.City, item.Freight);
            }

        }   

    }
}
