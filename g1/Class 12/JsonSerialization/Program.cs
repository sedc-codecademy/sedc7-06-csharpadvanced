using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JsonSerialization {
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

            Employee e2 = new Employee() {
                ID = 2,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "HTML/CSS" }
            };
            e2.SetPrivates("ul. Vodnjanska, Skopje");

            List<Employee> employees = new List<Employee>();
            employees.Add(e1);
            employees.Add(e2);

            string json = JsonConvert.SerializeObject(employees);
            string path = @"C:\Temp\JsonSerialization-List.json";
            File.WriteAllText(path, json);
             
            //deserializing json collection
            Console.WriteLine("Deserializing json collection...");
            List<Employee> empsDeserialized;

            string readJson = File.ReadAllText(path);
            empsDeserialized = JsonConvert.DeserializeObject<List<Employee>>(readJson);

            foreach (var e in empsDeserialized) {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
