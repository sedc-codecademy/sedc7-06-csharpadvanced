using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise
{
    [Serializable]
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
    class Program
    {
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathExercise1 = Path.Combine(defaultPath, @"Files\Exercise\Exercise1.bin");
            string pathExercise2 = Path.Combine(defaultPath, @"Files\Exercise\Exercise2.xml");
            
            List<Customer> customers = new List<Customer>
            {
                new Customer{CustomerID = 1, Name ="igor", Address = "Roza Luxemburg",City="Skopje"},
                new Customer{CustomerID = 2, Name = "ivan", Address = "Partizanska", City = "Ohrid"},
                new Customer{CustomerID = 3, Name = "dejan", Address = "Helsinshka", City = "Stip"}
            };
            List<Customer> customers1;
            List<Customer> customers2;

            IFormatter formatter = new BinaryFormatter();
            Console.WriteLine("\n------------------- List of Customer -------------------");
            Console.WriteLine("Binary serialization starting...");
            using (FileStream fs = new FileStream(pathExercise1, FileMode.Create))
            {
                formatter.Serialize(fs, customers);
            }
            Console.WriteLine("Binary serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            using (FileStream fs = new FileStream(pathExercise1, FileMode.Open))
            {
                customers1 = (List<Customer>)formatter.Deserialize(fs);
            }
            Console.WriteLine("Object deserialization process finished...");
            foreach (var dc in customers1)
            {
                dc.Print();
            }

            XmlSerializer serializer = new XmlSerializer(customers.GetType());
            Console.WriteLine("\n------------------- List of Customer -------------------");
            Console.WriteLine("XML serialization starting...");
            using (FileStream fs = new FileStream(pathExercise2, FileMode.Create))
            {
                serializer.Serialize(fs, customers);
            }
            Console.WriteLine("Xml serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            using (FileStream fs = new FileStream(pathExercise2, FileMode.Open))
            {
                customers2 = (List<Customer>)serializer.Deserialize(fs);
            }
            Console.WriteLine("Object deserialization process finished...");
            foreach (var dc in customers2)
            {
                dc.Print();
            }

            Console.ReadLine();
        }
    }
}
