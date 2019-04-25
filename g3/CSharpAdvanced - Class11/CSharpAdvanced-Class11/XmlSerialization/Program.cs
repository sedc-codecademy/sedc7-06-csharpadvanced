using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization {
    class Program {
        static void Main(string[] args) {

            Employee e1 = new Employee() {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "SQL Server" }
            };
            e1.SetPrivates("ul. Partizanski odredi, Skopje");

            XmlSerializer serializer = new XmlSerializer(e1.GetType());
            string path = @"C:\Users\igor.micev\Desktop\XmlSerialization.xml";
            using (StreamWriter sw = new StreamWriter(path)) {
                serializer.Serialize(sw, e1);
            }
            Console.WriteLine("xml object serialized .");

            Console.WriteLine("xml object deserialization...");
            Employee empDeserialized;
            using(StreamReader sr = new StreamReader(path)) {
                empDeserialized = (Employee)serializer.Deserialize(sr);
            }
            Console.WriteLine("xml object deserialized.");
            Console.WriteLine(empDeserialized.ToString());
            
            Employee e2 = new Employee() {
                ID = 2,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "HTML/CSS" }
            };
            e2.SetPrivates("ul. Vodnjanska, Skopje");

            Console.WriteLine("xml list serialized.");
            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);
            serializer = new XmlSerializer(employees.GetType());
            string path2 = @"C:\Users\igor.micev\Desktop\XmlSerialization-List.xml";
            using (StreamWriter sw = new StreamWriter(path2)) {
                serializer.Serialize(sw, employees);
            }

            using (FileStream sw = new FileStream(path2,FileMode.Create)) {
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

            //Demo for XmlEnum
            Printer printer = new Printer();
            printer.Name = "IT-2-floor";
            printer.Status = PrinterStatus.TonerExhausted;

            string path3 = @"C:\Users\igor.micev\Desktop\XmlSerialization-Enum.xml";
            //get the type for the serialization
            serializer = new XmlSerializer(printer.GetType());
            using(StreamWriter sw = new StreamWriter(path3)) {
                serializer.Serialize(sw, printer);
            }

        }
    }
}
