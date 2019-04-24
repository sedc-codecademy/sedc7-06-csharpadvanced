using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization
{
    class Program
    {
        #region Info
        /*
        - Serialization is the process of converting an object's state into information
            that can be stored for later retrieval or that can be sent to another system.
        - The reverse process is called deserialization
        - Binary serialization allows objects to be converted to binary streams,
            which may be stored in files or transported to other systems
        - Classes from System.Runtime.Serialization and System.Runtime.Serialization.Formatters.Binary
        - [Serializable]  is required
        */
        #endregion
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathBinarySerialization1 = Path.Combine(defaultPath, @"Files\BinarySerialization\BinarySerialization1.bin");
            string pathBinarySerialization2 = Path.Combine(defaultPath, @"Files\BinarySerialization\BinarySerialization2.bin");

            IFormatter formatter = new BinaryFormatter();

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

            #region Binary Serialization and Deserialization - Employee
            //Console.WriteLine("\n------------------- Employee -------------------");
            //Console.WriteLine("Binary serialization starting...");
            //using (FileStream fs = new FileStream(pathBinarySerialization1, FileMode.Create))
            //{
            //    formatter.Serialize(fs, e1);
            //}
            //Console.WriteLine("Binary serialization finished...");

            //Console.WriteLine("Object deserialization process starting...");
            //using (FileStream fs = new FileStream(pathBinarySerialization1, FileMode.Open))
            //{
            //    de1 = (Employee)formatter.Deserialize(fs);
            //}
            //Console.WriteLine("Object deserialization process finished...");

            //Console.WriteLine($"Priniting object: {de1.ToString()}");
            #endregion

            List<Employee> employees = new List<Employee>();
            Employee e2 = new Employee()
            {
                ID = 2,
                Name = "Martin",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML" }
            };
            employees.Add(e1);
            employees.Add(e2);
            List<Employee> demployees;

            #region Binary Serialization and Deserialization - List of Employee
            Console.WriteLine("\n------------------- List of Employee -------------------");
            Console.WriteLine("Binary serialization starting...");
            using (FileStream fs = new FileStream(pathBinarySerialization2, FileMode.Create))
            {
                formatter.Serialize(fs, employees);
            }
            Console.WriteLine("Binary serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            using (FileStream fs = new FileStream(pathBinarySerialization2, FileMode.Open))
            {
                demployees = (List<Employee>)formatter.Deserialize(fs);
            }
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
