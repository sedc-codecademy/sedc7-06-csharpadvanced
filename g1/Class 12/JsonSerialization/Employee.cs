using System.Collections.Generic;
using Newtonsoft.Json;


namespace JsonSerialization {

    //https://www.newtonsoft.com/json/help/html/SerializationAttributes.htm
    public class Employee {
        [JsonProperty]
        public int ID { get; set; }
        [JsonProperty]
        public string Name { get; set; } 
        [JsonIgnore]
        public char Gender { get; set; }
        [JsonProperty]
        public string WorkPhone { get; set; }
        [JsonIgnore]
        private string Address { get; set; }
        [JsonProperty]
        public List<string> Skills { get; set; }

        public void SetPrivates(string address) {
             Address = address;
        } 
        public override string ToString() {
            return
                $"ID: {ID}, Name: {Name}, Gender: {Gender}, WorkPhone: {WorkPhone}, Address: {Address}, Skills: {string.Join(", ", Skills)}";
        }
    }

}
