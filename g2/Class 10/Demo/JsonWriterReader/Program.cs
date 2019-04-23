using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonWriterReader
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public IList<string> Skills { get; set; }

        public Person() { }
        public Person(int id, string name, string address, string city, string email, IList<string> skills)
        {
            this.ID = id; this.Name = name; this.Address = address; this.City = city;
            this.Email = email; this.Skills = skills;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string defaultPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));
            //string path = @"C:\Users\igor.micev\Desktop\videogames.json";

            #region Writing json
            JObject videogameRatings = new JObject
             (
                new JProperty("Halo", 9),
                new JProperty("Starcraft", 9),
                new JProperty("Call of Duty", 7.5)
            );

            Console.WriteLine("--------------- Writing json directly to a file ---------------");
            string path = Path.Combine(defaultPath, @"Files\JsonWriterReader\VideoGames.csv");
            File.WriteAllText(path, videogameRatings.ToString());

            Console.WriteLine("--------------- Writing json with JsonTextWriter ---------------");
            string path2 = Path.Combine(defaultPath, @"Files\JsonWriterReader\VideoGames2.csv");
            using (StreamWriter file = File.CreateText(path2))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                videogameRatings.WriteTo(writer);
            }
            #endregion

            #region Reading json
            Console.WriteLine("--------------- Reading json directly from a file ---------------");
            JObject o1 = JObject.Parse(File.ReadAllText(path));
            Console.WriteLine(o1.ToString());
            #endregion

            #region Writing a collection into json file
            Console.WriteLine("--------------- Writing a collection into json file ---------------");
            Person person = new Person(1234, "Igor Micev", "Roza Luxemburg", "Skopje", "igormicev@gmail.com",
                            new List<string> { "C#", "SQL Server", "SSIS", "SSAS" });
            JObject jP1 = (JObject)JToken.FromObject(person);
            //Console.WriteLine(jP1.ToString());

            Person person2 = new Person(1235, "Dejan Jovanov", "Vodnjanska", "Skopje", "dejan.jovanov@gmail.com",
                             new List<string> { "C#", "Node.js", "HTML/CSS" });
            JObject jP2 = (JObject)JToken.FromObject(person2);
            //Console.WriteLine(jP2.ToString());

            Console.WriteLine("--------------- Writing Json List ---------------");
            List<JObject> jPersons = new List<JObject>();
            jPersons.Add(jP1);
            jPersons.Add(jP2);

            string jPersonsString = JsonConvert.SerializeObject(jPersons, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(jPersonsString);
            string path3 = Path.Combine(defaultPath, @"Files\JsonWriterReader\JPersons.csv");
            File.WriteAllText(path3, jPersonsString);

            Console.WriteLine("--------------- Writing Json Array ---------------");
            JArray jPersons2 = new JArray();
            jPersons2.Add((JObject)jP1);
            jPersons2.Add((JObject)jP2);

            string jPersonsString2 = jPersons2.ToString();
            Console.WriteLine(jPersonsString2);
            string path4 = Path.Combine(defaultPath, @"Files\JsonWriterReader\JPersons2.csv");
            File.WriteAllText(path4, jPersons2.ToString());
            #endregion

            Console.ReadLine();
        }
    }
}
