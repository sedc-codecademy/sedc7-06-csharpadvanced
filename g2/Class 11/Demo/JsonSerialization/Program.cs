using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    class Program
    {
        #region Info
        /*
        - Serialization is the process of converting an object's state into information
            that can be stored for later retrieval or that can be sent to another system.
        - The reverse process is called deserialization
        - Similar as the XML serialization, but more flexible and more efficient
        - Serialized information can be larger than its binary equivalent
            However, it is human-readable and, in appropriate scenarios, can be easily edited
        - [Serializable] is not required
        - OptOut(default): All public members are serialized by default
            Members can be excluded with JsonIgnore
        - OptIn: Only members marked with JsonProperty are serialized
        - Fields: All public and private fields are serialized
            Members can be excluded with JsonIgnore
        */
        #endregion
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathJsonSerialization1 = Path.Combine(defaultPath, @"Files\JsonSerialization\JsonSerialization1.json");

            List<Employee> employees = new List<Employee>();
            Employee e1 = new Employee()
            {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "SQL Server" }
            };
            e1.SetPrivates("ul. Partizanski odredi, Skopje");
            Employee e2 = new Employee()
            {
                ID = 2,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "HTML/CSS" }
            };
            e2.SetPrivates("ul. Vodnjanska, Skopje");
            employees.Add(e1);
            employees.Add(e2);
            List<Employee> demployees;

            #region Json Serialization and Deserialization - Employee
            Console.WriteLine("\n------------------- Employee -------------------");
            Console.WriteLine("Json serialization starting...");
            string json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(pathJsonSerialization1, json);
            Console.WriteLine("Json serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            string readJson = File.ReadAllText(pathJsonSerialization1);
            demployees = JsonConvert.DeserializeObject<List<Employee>>(readJson);
            Console.WriteLine("Object deserialization process finished...");

            foreach (var de in demployees)
            {
                Console.WriteLine($"Priniting object: {de.ToString()}");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
