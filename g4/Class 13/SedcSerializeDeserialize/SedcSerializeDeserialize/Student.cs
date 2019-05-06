using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SedcSerializeDeserialize
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Student
    {
        [JsonProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [JsonProperty]
        public bool IsPartTime { get; set; }

        public Student()
        {

        }
        [JsonConstructor]
        public Student(string firstName)
        {
            FirstName = "Mr/Ms " + firstName;  
        }

        [OnSerializing]
        internal void OnSerializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE SERIALIZING A STUDENT!");
        }

        [OnDeserializing]
        internal void OnDeserializeMethod(StreamingContext context)
        {
            Console.WriteLine("WE ARE DESERIALIZING A STUDENT!");
        }
    }
}
