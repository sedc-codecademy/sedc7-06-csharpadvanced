using System.Collections.Generic;

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
            ID = id; Name = name; Address = address; City = city;
            Email = email; Skills = skills;
        }
    }
}