using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>
            {
                new Course(1, "Js Basic", 40, CourseType.Fe),
                new Course(1, "Advance JS", 60, CourseType.Fe),
                new Course(2, "C# Basic", 40, CourseType.Be),
                new Course(2, "C# Advance", 60, CourseType.Be),
                new Course(3, "MVC", 40, CourseType.Be)
            };


            Student martin = new Student("Martin", "martin@gmail.com", "Mkd", 25, false, new List<Course>());
            Student ana = new Student("Ana", "ana@outlook.com", "Srb", 23, true, new List<Course>());
            Student risto = new Student("Risto", "risto@gmail.com", "Mkd", 29, false, new List<Course>());


            List<Student> students = new List<Student> { martin, ana, risto };



            Student ristoFromList = students.FirstOrDefault(x => x.Name == "Risto");

            if (ristoFromList != null)
            {
                ristoFromList.Courses = courses.Where(x => x.Type == CourseType.Be).ToList();
            }


            Student anaFromList = students.SingleOrDefault(x => x.Email == "ana@outlook.com");

            if (anaFromList != null)
            {
                anaFromList.Courses = courses.Where(x => x.Name.Contains("Advance")).ToList();
            }

            int studentsWithGmailAccount = students.Count(x => x.Email.Contains("gmail"));

            var averageAge = students.Where(x => x.Sex).Select(x => x.Age).Sum() / (double) students.Count(x => x.Sex);
            var averageAge1 = students.Where(x => x.Sex).Average(x => x.Age);
        }
    }
}
