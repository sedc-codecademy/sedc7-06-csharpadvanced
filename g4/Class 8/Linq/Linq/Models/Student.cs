using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } // List<string>
        public string LastName { get; set; }
        public int Age { get; set; } // List<int>
        public bool IsPartTime { get; set; } // List<bool>
        public List<Subject> Subjects { get; set; } // List<List<Subject>>
        public Student()
        {

        }
        public Student(int id, string first, string last, int age, bool partTime)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Age = age;
            IsPartTime = partTime;
        }
    }
}
