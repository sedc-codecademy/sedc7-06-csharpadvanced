using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Miodrag",
                Gender = 'M',
                WorkPhone = "78123456",
                Address = "Address 1",
                Skills = new List<string>() { "C#", "ASP.NET", "Git" }
            };

            Employee anotherEmployee = new Employee()
            {
                ID = 3,
                Name = "Andrej",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML", "Visual Studio" }
            };

            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(anotherEmployee);

            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            string path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\JsonSerialization-List.json";
            File.WriteAllText(path, json);

            // Deserializing json collection
            Console.WriteLine("Deserializing json collection...");
            List<Employee> empsDeserialized;

            string readJson = File.ReadAllText(path);
            empsDeserialized = JsonConvert.DeserializeObject<List<Employee>>(readJson);

            foreach (var e in empsDeserialized)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
