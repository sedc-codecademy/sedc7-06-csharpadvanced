using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization {
    class Program {
        static void Main(string[] args) {
            Employee e1 = new Employee {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string> { "C#", "SQL Server" }
            }; 
            e1.SetPrivates("ul. Partizanski odredi, Skopje");  

            IFormatter formatter = new BinaryFormatter();
            var path = @"C:\Temp\BinarySerialization.bin";

            Console.WriteLine("Binary serialization starting...");
            using (FileStream fs = new FileStream(path, FileMode.Create)) {
                formatter.Serialize(fs, e1); 
                fs.Flush();
            }
            Console.WriteLine("Binary serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            Employee e2;
            using (FileStream fs = new FileStream(path, FileMode.Open)) {
                e2 = (Employee)formatter.Deserialize(fs);
            }
            Console.WriteLine("Printing deserialized object:");
            Console.WriteLine(e2.ToString());

            Console.WriteLine("Now serializing a list of Employees...");
            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            Employee e3 = new Employee() {
                ID = 3,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML" }
            };
            employees.Add(e3);
            using (FileStream fs = new FileStream(path, FileMode.Create)) {
                formatter.Serialize(fs, employees);
            }

            Console.WriteLine("List deserialization process starting...");
            Console.WriteLine("----------------------------------------");
            List<Employee> empsDeserialize;
            using (FileStream fs = new FileStream(path, FileMode.Open)) {
                empsDeserialize = (List<Employee>)formatter.Deserialize(fs);
            }
            foreach (var e in empsDeserialize) {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("List deserialization process ended...");
            Console.WriteLine("----------------------------------------");

        }
    }
}
