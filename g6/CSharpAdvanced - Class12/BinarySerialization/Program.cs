using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Action line = () => Console.WriteLine();

            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Miodrag",
                Gender = 'M',
                WorkPhone = "78123456",
                Address = "Address 1",
                Skills = new List<string>() { "C#", "ASP.NET", "Git" }
            };

            IFormatter formatter = new BinaryFormatter();
            string path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\Employee.bin";

            Console.WriteLine("Binary serialization starting...");
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fileStream, employee);
            }
            Console.WriteLine("Binary serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            Employee emptyEmployee = null;
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                emptyEmployee = (Employee)formatter.Deserialize(fileStream);
            }
            Console.WriteLine("Printing deserialized object:");
            Console.WriteLine(emptyEmployee.ToString());

            Console.WriteLine("Now serializing a list of Employees...");
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            Employee anotherEmployee = new Employee()
            {
                ID = 3,
                Name = "Andrej",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML", "Visual Studio" }
            };

            string pathForList = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\EmployeeList.bin";
            employees.Add(anotherEmployee);
            using (FileStream fs = new FileStream(pathForList, FileMode.Create))
            {
                formatter.Serialize(fs, employees);
            }

            Console.WriteLine("List deserialization process starting...");
            Console.WriteLine("----------------------------------------");
            List<Employee> empsDeserialize;
            using (FileStream fs = new FileStream(pathForList, FileMode.Open))
            {
                empsDeserialize = (List<Employee>)formatter.Deserialize(fs);
            }
            foreach (var e in empsDeserialize)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("List deserialization process ended...");
            Console.WriteLine("----------------------------------------");
        }
    }
}
