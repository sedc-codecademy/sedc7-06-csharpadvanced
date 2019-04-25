using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerialization {

    [Serializable]
    public class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string WorkPhone { get; set; } 
        private string Address { get; set; }
        public List<string> Skills { get; set; }

        public void SetPrivates(string address) {
            this.Address = address;
        } 
        public override string ToString() {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
                ,ID, Name, Gender, WorkPhone, Address, string.Join(", ",Skills));
        }
    }
}
