using System;
using System.Collections.Generic;

namespace BinarySerialization
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }
        public List<string> Skills { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
                , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
        }
    }
}