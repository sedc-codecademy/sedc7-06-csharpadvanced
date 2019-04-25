﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonWriterReader {
    class Program {
        static void Main(string[] args) {
            JObject videogameRatings = new JObject(
            new JProperty("Halo", 9),
            new JProperty("Starcraft", 9),
            new JProperty("Call of Duty", 7.5));

            string path = @"C:\Temp\videogames.json";

            // write JSON directly to a file
            File.WriteAllText(path, videogameRatings.ToString());

            //write JSON with JsonTextWriter
            path = @"C:\Temp\videogames2.json";
            using (StreamWriter file = File.CreateText(path))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                videogameRatings.WriteTo(writer);
            }

            // read JSON directly from a file
            JObject o1 = JObject.Parse(File.ReadAllText(path));
            Console.WriteLine(o1.ToString());

            //writing a collection into json file
            Person person = new Person(1234, "Igor Micev", "Roza Luxemburg", "Skopje", "igormicev@gmail.com",
                new List<string> { "C#", "SQL Server", "SSIS", "SSAS" });
            JObject jP1 = (JObject)JToken.FromObject(person);
            Console.WriteLine(jP1.ToString());

            Person person2 = new Person(1235, "Dejan Jovanov", "Vodnjanska", "Skopje", "dejan.jovanov@gmail.com"
                , new List<string> { "C#", "Node.js", "HTML/CSS" });
            JObject jP2 = (JObject)JToken.FromObject(person2);
            Console.WriteLine(jP2.ToString());

            List<JObject> jPersons = new List<JObject>();
            jPersons.Add(jP1);
            jPersons.Add(jP2);

            string json = JsonConvert.SerializeObject(jPersons, Formatting.Indented);
            Console.WriteLine(json);

            JArray myArray = new JArray { jP1, jP2 };

            path = @"C:\Temp\JsonPersonsWritten.json";

            // write JSON array directly to a file
            File.WriteAllText(path, myArray.ToString());

        }
    }
}