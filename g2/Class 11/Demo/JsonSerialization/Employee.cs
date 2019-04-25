﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public char Gender { get; set; }
    //    public string WorkPhone { get; set; }
    //    private string Address { get; set; }
    //    public List<string> Skills { get; set; }

    //    public void SetPrivates(string address)
    //    {
    //        Address = address;
    //    }
    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
    //            , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
    //    }
    //}

    //https://www.newtonsoft.com/json/help/html/SerializationAttributes.htm
    //[JsonObject(MemberSerialization.OptIn)]
    //public class Employee
    //{
    //    [JsonProperty]
    //    public int ID { get; set; }
    //    [JsonProperty]
    //    public string Name { get; set; }
    //    public char Gender { get; set; }
    //    [JsonProperty]
    //    public string WorkPhone { get; set; }
    //    [JsonProperty]
    //    private string Address { get; set; }
    //    [JsonProperty]
    //    public List<string> Skills { get; set; }

    //    public void SetPrivates(string address)
    //    {
    //        Address = address;
    //    }
    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
    //            , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
    //    }
    //}

    //[JsonObject(MemberSerialization.OptOut)]
    //public class Employee
    //{
    //    [JsonIgnore]
    //    public int ID { get; set; }
    //    [JsonIgnore]
    //    public string Name { get; set; }
    //    public char Gender { get; set; }
    //    public string WorkPhone { get; set; }
    //    private string Address { get; set; }
    //    public List<string> Skills { get; set; }

    //    public void SetPrivates(string address)
    //    {
    //        Address = address;
    //    }
    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
    //            , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
    //    }
    //}

    [JsonObject(MemberSerialization.Fields)]
    public class Employee
    {
        [JsonIgnore]
        public int ID { get; set; }
        [JsonIgnore]
        public string Name { get; set; }
        public char Gender { get; set; }
        public string WorkPhone { get; set; }
        private string Address { get; set; }
        public List<string> Skills { get; set; }

        public void SetPrivates(string address)
        {
            Address = address;
        }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, WorkPhone: {3}, Address: {4}, Skills: {5}"
                , ID, Name, Gender, WorkPhone, Address, string.Join(", ", Skills));
        }
    }
}
