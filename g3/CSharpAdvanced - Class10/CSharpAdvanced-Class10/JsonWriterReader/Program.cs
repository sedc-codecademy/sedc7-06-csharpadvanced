﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Xml.Linq;

namespace JsonWriterReader {
    class Program {

        class Person {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Email { get; set; }
            public IList<string> Skills { get; set; }

            public Person() { }
            public Person(int id, string name, string address, string city, string email, IList<string> skills) {
                ID = id; Name = name; Address = address; City = city;
                Email = email; Skills = skills;
            }             
        }

        static void Main(string[] args) { 

            JObject videogameRatings = new JObject(
            new JProperty("Halo", 9),
            new JProperty("Starcraft", 9),
            new JProperty("Call of Duty", 7.5));

            string path = @"C:\Users\igor.micev\Desktop\videogames.json";

            // write JSON directly to a file
            File.WriteAllText(path, videogameRatings.ToString());

            JObject o = new JObject() {
                new JProperty("Name","Igor"),
                new JProperty("Age",35),
                new JProperty("Education","SEDC")
            };
            Console.WriteLine(o.ToString());

            List<string> strings = new List<string>() { "C#", "SQL Server" };
            o["Skills"] = JToken.FromObject(strings);

            string[] companies = new string[] { "Seavus", "SEDC" };
            JArray jArray = new JArray();
            foreach (var item in companies) {
                jArray.Add(item);
            }
            o.Add("Companies", (JToken)jArray);
            Console.WriteLine(o.ToString());

            path = @"C:\Users\igor.micev\Desktop\myDetails.json";
            System.IO.File.WriteAllText(path, o.ToString());

            //write JSON with JsonTextWriter
            path = @"C:\Users\igor.micev\Desktop\videogames2.json";
            using (StreamWriter file = File.CreateText(path))
            using (JsonTextWriter writer = new JsonTextWriter(file)) {
                videogameRatings.WriteTo(writer);
            }

            // read JSON directly from a file
            Console.WriteLine("Reading json from file");
            JObject o1 = JObject.Parse(File.ReadAllText(path));
            Console.WriteLine(o1.ToString());

            // writing a collection into json file
            Person person = new Person(1234,"Igor Micev","Roza Luxemburg","Skopje","igormicev@gmail.com",
                new List<string> { "C#", "SQL Server", "SSIS", "SSAS" });            
            JObject jP1 = (JObject)JToken.FromObject(person);
            Console.WriteLine(jP1.ToString());

            Person person2 = new Person(1235, "Martin Panovski", "Vodnjanska", "Skopje", "martin.panovski@gmail.com"
                , new List<string> { "C#", "Node.js", "HTML/CSS" });
            JObject jP2 = (JObject)JToken.FromObject(person2);
            Console.WriteLine(jP2.ToString());

            List<JObject> jPersons = new List<JObject>();
            jPersons.Add(jP1);
            jPersons.Add(jP2);

            string json = JsonConvert.SerializeObject(jPersons, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);             

            JArray myArray = new JArray();
            myArray.Add(jP1);
            myArray.Add(jP2);

            path = @"C:\Users\igor.micev\Desktop\JsonPersonsWritten.json";

            // write JSON array directly to a file
            File.WriteAllText(path, myArray.ToString()); 

        }
    }
}