using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate {
    class Program {

        class Student {
            public string FullName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args) {

            //Using Func<TResult>
            Func<double> ddv = delegate { return 18.0; };
            Console.WriteLine("Tax rate: {0:F1}%",ddv());

            //Using Func with parameters
            Func<int, int, int, long> volume = delegate (int w, int l, int h) { return w * l * h; };
            Console.WriteLine("Multiply: {0}", volume(2, 3, 4));

            Func<int, int, bool> isEqual = (x, y) => x == y;
            Console.WriteLine(isEqual(4, 5));
            Console.WriteLine(isEqual(5, 5));

            Func<int, string, bool> isTextLongerThan = (int x, string s) => s.Length > x;
            Console.WriteLine("Text longer than 10? {0}",isTextLongerThan(10,"Test string len"));

            Student student = new Student { FullName = "Marko", Age = 19 };
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            Console.WriteLine($"Student {student.FullName} is teenager: {isStudentTeenAger(student)}");
            
        }
    }
}
