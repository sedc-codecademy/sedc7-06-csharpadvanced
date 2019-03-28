using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Student: User
    {
        public Dictionary<Course, int> Grades { get; set; } = new Dictionary<Course, int>();

        public void SetGrade(Course course, int grade)
        {
            if (Grades.ContainsKey(course))
            {
                Grades[course] = grade;
            }
            else
            {
                Grades.Add(course, grade);
            }
        }

        public override string GetRole()
        {
            return "Student";
        }

        public void Enroll(Course course)
        {

        }

        public override IEnumerable<object> GetSomething()
        {
            return Grades.Select(kvp => $"{kvp.Key.Title}: {kvp.Value}");
        }
    }
}
