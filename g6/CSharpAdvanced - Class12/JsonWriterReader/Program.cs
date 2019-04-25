using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JsonWriterReader
{
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
                this.ID = id; this.Name = name; this.Address = address; this.City = city;
                this.Email = email; this.Skills = skills;
            }             
        }

        static void Main(string[] args) { 

            JObject videogameRatings = new JObject(
            new JProperty("Counter Strike", 9),
            new JProperty("Starcraft", 9),
            new JProperty("Call of Duty", 7.5));

            string path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\videogames.json";

            // Write JSON directly to a file
            File.WriteAllText(path, videogameRatings.ToString()); 

            //write JSON with JsonTextWriter
            path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\videogames2.json";
            using (StreamWriter file = File.CreateText(path))
            using (JsonTextWriter writer = new JsonTextWriter(file)) {
                videogameRatings.WriteTo(writer);
            }
            
            // Read JSON directly from a file
            JObject o1 = JObject.Parse(File.ReadAllText(path));
            Console.WriteLine(o1.ToString());

            // Writing a collection into json file
            Person person = new Person(1234,"Miodrag Cekikj","Address 1","Skopje","cekicmiodrag@gmail.com",
                new List<string> { "C#", ".NET", "Sql Server", "MVC" });            
            JObject jP1 = (JObject)JToken.FromObject(person);
            Console.WriteLine(jP1.ToString());

            Person person2 = new Person(1235, "Andrej Chichakovski", "Address 2", "Skopje", "andrejchichak@gmail.com"
                , new List<string> { "C#", "Web API", "HTML/CSS" });
            JObject jP2 = (JObject)JToken.FromObject(person2);
            Console.WriteLine(jP2.ToString());

            List<JObject> jPersons = new List<JObject>();
            jPersons.Add(jP1);
            jPersons.Add(jP2);

            string json = JsonConvert.SerializeObject(jPersons, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);             

            JArray myArray = new JArray();
            myArray.Add((JObject)jP1);
            myArray.Add((JObject)jP2);

            path = @"C:\Users\Miodrag.Cekikj\Desktop\GeneratedFiles\JsonPersonsWritten.json";

            // Write JSON array directly to a file
            File.WriteAllText(path, myArray.ToString()); 

        }
    }
}
