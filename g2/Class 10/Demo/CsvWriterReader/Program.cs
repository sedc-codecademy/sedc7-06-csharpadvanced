using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            path = Path.Combine(path, @"Files\CsvWriterReader\Customers.csv");
            //string path = @"C:\Users\igor.micev\Desktop\Customers.csv";

            #region Writing csv
            Console.WriteLine("--------------- Writing csv ---------------");
            List<Customer> customersToWrite = new List<Customer>
            {
                new Customer{CustomerID = 1, Name ="igor", Address = "Roza Luxemburg",City="Skopje"},
                new Customer{CustomerID = 2, Name = "ivan", Address = "Partizanska", City = "Ohrid"},
                new Customer{CustomerID = 3, Name = "dejan", Address = "Helsinshka", City = "Stip"}
            };

            using (StreamWriter writer = new StreamWriter(path))
            using (CsvWriter csv = new CsvWriter(writer))
            {
                csv.Configuration.Delimiter = ";";
                csv.WriteRecords(customersToWrite);
            }
            #endregion
            


            #region Reading csv
            Console.WriteLine("--------------- Reading from csv into class list---------------");
            List<Customer> customersToRead = new List<Customer>();
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = ";";
                customersToRead = csv.GetRecords<Customer>().ToList();
                foreach (Customer cust in customersToRead)
                {
                    cust.Print();
                }
            }
            #endregion


            Console.ReadLine();
        }
    }
}
