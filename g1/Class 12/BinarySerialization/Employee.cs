using System;
using System.Collections.Generic;

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
            Address = address;
        } 
        public override string ToString() {
            return
                $"ID: {ID}, Name: {Name}, Gender: {Gender}, WorkPhone: {WorkPhone}, Address: {Address}, Skills: {string.Join(", ", Skills)}";
        }
    }
}
