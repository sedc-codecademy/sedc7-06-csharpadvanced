using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ex1
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string WorkPhone { get; set; }
        private string Address { get; set; }
        public List<string> Skills { get; set; }

        public void SetPrivates(string address)
        {
            Address = address;
        }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
                , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\igor.mitkovski\Desktop\sedc7-advcscharip\CSharpAdvanced - Class11\Demo\Files\Ex1\Ex1.json";
            Employee e1 = new Employee()
            {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "SQL Server" }
            };
            e1.SetPrivates("ul. Partizanski odredi, Skopje");
            Employee de1;
            string json = JsonConvert.SerializeObject(e1, Formatting.Indented);
            File.WriteAllText(path, json);
            string readJson = File.ReadAllText(path);
            de1 = JsonConvert.DeserializeObject<Employee>(readJson);
            Console.WriteLine($"Priniting object: {de1.ToString()}");
            Console.ReadLine();
        }
    }
}
