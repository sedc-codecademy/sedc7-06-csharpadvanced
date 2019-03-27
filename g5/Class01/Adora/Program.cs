using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adora
{
    class Program
    {
        static void Main(string[] args)
        {
            //var w1 = new Person {
            //    FirstName = "Wekoslav",
            //    LastName = "Stefanovski",
            //    Age = 0x29
            //};

            //var w2 = new Person("Wekoslav", "Stefanovski", 0x29);
            //Console.WriteLine(w2.Id);

            // var s1 = new Student();

            var student = new Student("Group 5", "Emilija", "Filiposka-Velichkovska");
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Group);
            Console.WriteLine(student.Id);

            var weko = PersonRepo.Group5.Lecturers["Weko"];
            Console.WriteLine(weko.FirstName);
        }
    }
}
