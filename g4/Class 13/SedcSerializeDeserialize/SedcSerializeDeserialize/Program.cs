using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcSerializeDeserialize
{
    class Program
    {
        static string directoryPath = @"C:\Users\DraganGelevski\source\repos\SedcSerializeDeserialize\SedcSerializeDeserialize\papka";
        static SerializationService serializeService = new SerializationService();
        static string ReadFile(string path)
        {
            string result = "";
            if (!File.Exists(path))
            {
                return "File does not exist!";
            }
            using(StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file!");
            return result;
        }
        static void WriteFile(string path, string data)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfully written a file!");
        }
        static void Main(string[] args)
        {
            // This does not work
            //Console.WriteLine((new Student() { FirstName = "bob" }).ToString());

            // Poor mans Serialize / Deserialize 
            Student bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 40,
                IsPartTime = false
            };
            if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);
            //string bobString = serializeService.SerializeStudent(bob);
            //WriteFile(directoryPath + @"\myFirstJson.txt", bobString);
            //WriteFile(directoryPath + @"\myFirstJson.json", bobString);
            //string jsonStudent = ReadFile(directoryPath + @"\myFirstJson.json");
            //Student deserializedStudent = serializeService.DeserializeStudent(jsonStudent);
            //Console.WriteLine(deserializedStudent.Age);

            // Newtonsoft JSON serialize / deserialize

            string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
            Console.WriteLine(bobSerializedNewtonsoft);

            Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);

            Console.WriteLine(bobDeserializedNewtonsoft.FirstName);
            Console.ReadLine();
        }
    }
}
