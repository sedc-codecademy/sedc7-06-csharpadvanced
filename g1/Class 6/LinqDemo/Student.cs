using System.Collections.Generic;

namespace LinqDemo
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public List<Course> Courses { get; set; }

        public Student(string name, string email, string country, int age, bool sex, List<Course> courses)
        {
            Name = name;
            Email = email;
            Country = country;
            Age = age;
            Sex = sex;
            Courses = courses;
        }
    }
}
