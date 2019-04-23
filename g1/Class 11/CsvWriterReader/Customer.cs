using System;

namespace CsvWriterReader
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
}