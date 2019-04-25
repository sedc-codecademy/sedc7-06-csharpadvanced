using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerialization {
     
    public class Employee {
        public int Id { get; set; }
        [XmlElement(ElementName = "FullName", 
            Namespace = "http://www.sedc.mk/")]
        public string Name { get; set; }
        [XmlIgnore]
        public char Gender { get; set; }
        public string WorkPhone { get; set; }
        private string Address { get; set; }
        [XmlArray("Skill")]
        [XmlArrayItem("Technology")]
        public List<string> Skills { get; set; }

        public void SetPrivates(string address) {
             Address = address;
        } 
        public override string ToString() {
            return
                $"ID: {Id}, Name: {Name}, Gender: {Gender}, WorkPhone: {WorkPhone}, Address: {Address}, Skills: {string.Join(", ", Skills)}";
        }
    }

}
