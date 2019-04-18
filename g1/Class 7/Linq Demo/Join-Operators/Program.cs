using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFromXml;
using DataFromXml.Models;
using DataFromXml.Services;

namespace Join_Operators {
    class Program {
        static void Main(string[] args) {
            
            //load all the products, customers, orders
            List<Product> products = ProductService.GetAllProducts();
            List<Customer> customers = CustomerService.GetAllCustomers();
            List<Order> orders = OrderService.GetAllOrders();
            
            //Linq 102: This sample shows how to efficiently join elements of two sets based on equality 
            //between key expressions over the two. Additinally filetring is done with a Where clause.
            //sql-like query:
            var q =
                from c in customers
                join o in orders on c.CustomerId equals o.CustomerId
                where c.CustomerId == "VINET"
                select new { Customer = c.CustomerId, City = o.ShipCity, o.Freight };

            foreach (var item in q) {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}",item.Customer, item.City, item.Freight);
            }

            //lambda-like query:
            var q2 = customers.Join(orders,
                c => c.CustomerId,
                o => o.CustomerId,
                (c, o) => new { Customer = c.CustomerId, City = o.ShipCity, Freight = o.Freight, Employee = o.EmployeeId })
                .Where(c => c.Customer == "VINET");
            foreach (var item in q2) {
                Console.WriteLine("Customer {0}, City {1}, Freight {2}", item.Customer, item.City, item.Freight);
            }

        }   

    }
}
