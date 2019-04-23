using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization {
     
    public class Employee {
        public int ID { get; set; }
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
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
                ,ID, Name, Gender, WorkPhone, Address, string.Join(", ",Skills));
        }
    }

}
