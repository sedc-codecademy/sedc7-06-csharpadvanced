using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;

namespace CsvWriterReader
{
    class Program
    {
        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }

            public void Print()
            {
                Console.WriteLine($"{CustomerID}, {Name}, {Address}, {City}");
            }
        }

        static void Main(string[] args)
        {

            string path = @"C:\Users\Miodrag.Cekikj\Desktop\Customers11.csv";
            //writing csv
            var customers = new List<Customer> {
                new Customer{CustomerID = 1, Name ="Miodrag", Address = "Address 1",City="Ohrid"},
                new Customer{CustomerID = 2, Name = "Andrej", Address = "Address 2", City = "Berovo"},
                new Customer{CustomerID = 3, Name = "Someone", Address = "Some address", City = "Some city"}
            };

            using (var writer = new StreamWriter(path))
            {
                using (var csv = new CsvWriter(writer))
                {
                    //TRY TO IMPLEMENT THE WRITING OF ALL RECORDS
                }
            }

            //IMPLEMENT THE COMPLETE FLOW - WITH READING THE CONTENT FROM THE PREVIOUSLY CREATED FILE

        }
    }
}
