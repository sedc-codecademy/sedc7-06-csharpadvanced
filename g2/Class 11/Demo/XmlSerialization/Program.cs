using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program
    {
        #region Info
        /*
        - Serialization is the process of converting an object's state into information
            that can be stored for later retrieval or that can be sent to another system.
        - The reverse process is called deserialization
        - XML serialization allows public state of objects to be converted to XML,
            which may be stored in files or transported to other systems
        - Serialized information can be larger than its binary equivalent
            However, it is human-readable and, in appropriate scenarios, can be easily edited
        - Private properties and fields are not serialzied
        - [Serializable] is not required
        - XmlElement, XmlAttribute, XmlIgnore, XmlEnum
        */
        #endregion
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            string pathXmlSerialization1 = Path.Combine(defaultPath, @"Files\XmlSerialization\XmlSerialization1.xml");
            string pathXmlSerialization2 = Path.Combine(defaultPath, @"Files\XmlSerialization\XmlSerialization2.xml");
            string pathXmlSerialization3 = Path.Combine(defaultPath, @"Files\XmlSerialization\XmlSerialization3.xml");

            Employee e1 = new Employee()
            {
                ID = 1,
                Name = "Igor",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "SQL Server" }
            };
            e1.SetPrivates("ul. Partizanski odredi, Skopje");

            XmlSerializer serializer1 = new XmlSerializer(e1.GetType());

            #region XML Serialization and Deserialization - Employee
            //Console.WriteLine("\n------------------- Employee -------------------");
            //Console.WriteLine("XML serialization starting...");
            ////using (FileStream fs = new FileStream(pathXmlSerialization1, FileMode.Create))
            ////{
            ////    serializer1.Serialize(fs, e1);
            ////}
            //using (StreamWriter sw = new StreamWriter(pathXmlSerialization1))
            //{
            //    serializer1.Serialize(sw, e1);
            //}
            //Console.WriteLine("XML serialization finished...");

            //Console.WriteLine("Object deserialization process starting...");
            //Employee de1;
            ////using (FileStream fs = new FileStream(pathXmlSerialization1, FileMode.Open))
            ////{
            ////    de1 = (Employee)serializer1.Deserialize(fs);
            ////}
            //using (StreamReader sr = new StreamReader(pathXmlSerialization1))
            //{
            //    de1 = (Employee)serializer1.Deserialize(sr);
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
                Skills = new List<string>() { "C#", "HTML/CSS" }
            };
            e2.SetPrivates("ul. Vodnjanska, Skopje");
            employees.Add(e1);
            employees.Add(e2);
            List<Employee> demployees;

            XmlSerializer serializer2 = new XmlSerializer(employees.GetType());

            #region XML Serialization and Deserialization - List of Employee
            //Console.WriteLine("\n------------------- List of Employee -------------------");
            //Console.WriteLine("XML serialization starting...");

            ////using (FileStream fs = new FileStream(pathXmlSerialization2, FileMode.Create))
            ////{
            ////    serializer2.Serialize(fs, employees);
            ////}
            //using (StreamWriter sw = new StreamWriter(pathXmlSerialization2))
            //{
            //    serializer2.Serialize(sw, employees);
            //}
            //Console.WriteLine("Xml serialization finished...");

            //Console.WriteLine("Object deserialization process starting...");
            ////using (FileStream fs = new FileStream(pathXmlSerialization2, FileMode.Open))
            ////{
            ////    demployees = (List<Employee>)serializer2.Deserialize(fs);
            ////}
            //using (StreamReader sr = new StreamReader(pathXmlSerialization2))
            //{
            //    demployees = (List<Employee>)serializer2.Deserialize(sr);
            //}
            //Console.WriteLine("Object deserialization process finished...");

            //foreach (var de in demployees)
            //{
            //    Console.WriteLine($"Priniting object: {de.ToString()}");
            //}
            #endregion

            Printer p1 = new Printer();
            p1.Name = "IT-2-floor";
            p1.Status = PrinterStatus.TonerExhausted;

            XmlSerializer serializer3 = new XmlSerializer(p1.GetType());

            #region XML Serialization and Deserialization - Printer
            Console.WriteLine("\n------------------- Printer -------------------");
            Console.WriteLine("XML serialization starting...");
            using (StreamWriter sw = new StreamWriter(pathXmlSerialization3))
            {
                serializer3.Serialize(sw, p1);
            }
            Console.WriteLine("XML serialization finished...");

            Console.WriteLine("Object deserialization process starting...");
            Printer dp1;
            using (StreamReader sr = new StreamReader(pathXmlSerialization3))
            {
                dp1 = (Printer)serializer3.Deserialize(sr);
            }
            Console.WriteLine("Object deserialization process finished...");

            Console.WriteLine($"Priniting object: {dp1.ToString()}");
            #endregion

            Console.ReadLine();
        }
    }
}
