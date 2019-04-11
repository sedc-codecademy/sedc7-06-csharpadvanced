using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate {
    class Program {

        class Student {
            public string FullName { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args) {

            //Action using delegate
            Action<string> showMessage = delegate (string msg) { Console.WriteLine(msg); };
            showMessage("Hello from Action delegate");

            //Actions with anonymous call
            Action<string> showAnonymousMsg = (msg) => { Console.WriteLine(msg); };
            showAnonymousMsg("Hell from Action anonymous");

            Action line = () => Console.WriteLine();
            line();
            line();
            Console.WriteLine("-----two empty lines before-----");

            Action<string> greet = name => {
                string greeting = $"Hello {name}";
                Console.Write(greeting);
                Console.Write('\n');
            };
            greet("World");

            Action<Student> PrintStudentDetail = s => Console.WriteLine("Mame: {0}, Age: {1}",
                s.FullName, s.Age);
            Student student = new Student { FullName = "Marko", Age = 19 };
            PrintStudentDetail(student);

        }
    }
}
