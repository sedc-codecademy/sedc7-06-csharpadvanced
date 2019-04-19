using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace CsvWriterReader {     

    class Program {
        public class Customer {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }

            public void Print() {
                Console.WriteLine($"{CustomerID}, {Name}, {Address}, {City}");
            }
        }

        static void Main(string[] args) {

            string path = @"C:\Users\igor.micev\Desktop\Customers.csv";
            //writing csv
            var customers = new List<Customer> {
                new Customer{CustomerID = 1, Name ="igor", Address = "Roza Luxemburg",City="Skopje"},
                new Customer{CustomerID = 2, Name = "ivan", Address = "Partizanska", City = "Ohrid"},
                new Customer{CustomerID = 3, Name = "dejan", Address = "Helsinshka", City = "Stip"}
            };

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer)) {
                csv.WriteRecords(customers);
            }

            //reading from csv into class list
            List<Customer> csvCustomers = new List<Customer>();
            using (var reader = new StreamReader(path))
                using(var csv = new CsvReader(reader)) {
                var readCustomers = csv.GetRecords<Customer>();
                foreach (var cust in readCustomers) {
                    csvCustomers.Add(cust);
                }
            }
            
            foreach (var cust in csvCustomers) {
                cust.Print();
            }

        }
    }
}
