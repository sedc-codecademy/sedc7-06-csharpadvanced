using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program {
        static void Main(string[] args) {

            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Miodrag",
                Gender = 'M',
                WorkPhone = "78123456",
                Address = "Address 1",
                Skills = new List<string>() { "C#", "ASP.NET", "Git" }
            };

            XmlSerializer serializer = new XmlSerializer(employee.GetType());
            string path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\XmlSerialization.xml";
            using (StreamWriter sw = new StreamWriter(path)) {
                serializer.Serialize(sw, employee);
            }
            Console.WriteLine("xml object serialized .");

            Console.WriteLine("xml object deserialization...");
            Employee empDeserialized;
            using(StreamReader sr = new StreamReader(path)) {
                empDeserialized = (Employee)serializer.Deserialize(sr);
            }
            Console.WriteLine("xml object deserialized.");
            Console.WriteLine(empDeserialized.ToString());

            Employee anotherEmployee = new Employee()
            {
                ID = 3,
                Name = "Andrej",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML", "Visual Studio" }
            };

            Console.WriteLine("xml list serialized.");
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(anotherEmployee);
            serializer = new XmlSerializer(employees.GetType());

            string path2 = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\XmlSerialization-List.xml";
            using (StreamWriter sw = new StreamWriter(path2)) {
                serializer.Serialize(sw, employees);
            }

            Console.WriteLine("xml list deserialized.");
            List<Employee> empsDeserialized;
            using(StreamReader sr = new StreamReader(path2)) {
                empsDeserialized = (List<Employee>)serializer.Deserialize(sr);
            }
            foreach (var e in empsDeserialized) {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
