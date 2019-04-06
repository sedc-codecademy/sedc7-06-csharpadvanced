using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Introduction {
    class Program {

        public class Customer {
            public string Name { get; set; }
            public int ID { get; set; }
        }
        public class Employee {
            public string Name { get; set; }
            public int Age { get; set; }
            public Employee(string name, int age) {
                Name = name; Age = age;
            }
        }

        //This BuildList<T> generic method builds any list from an array as input param
        public static List<T> BuildList<T>(params T[] items) {
            return new List<T>(items); 
        }

        static void Main(string[] args) {

            List<int> ints = BuildList<int>(1, 2, 3);
            Print(ints);

            List<string> strings = BuildList<string>("Hi", "There"," <-- This is generic");
            Print(strings);

            List<Customer> customers = BuildList<Customer>(
                new Customer { Name = "SEDC", ID = 1 },
                new Customer { Name = "Seavus", ID = 2 }
                );
            Print(customers);

            Employee e1 = new Employee("igor", 35);
            Employee e2 = new Employee("dejan", 27);
            List<Employee> employees = BuildList<Employee>(
                e1, e2 
                );
            Print(employees);

            //Start with a Dictionary
            Dictionary<int, Employee> empsDict = new Dictionary<int, Employee>();
            empsDict.Add(0, e1);
            empsDict.Add(1, e2);
            //Copy from dictionary to array
            Employee[] empsArray = new Employee[empsDict.Count];
            empsDict.Values.CopyTo(empsArray,0);
            //Finally build a list of employees from that array with BuildList<T>
            List<Employee> listEmployees = BuildList(empsArray);
            Print(listEmployees);

        } //end Main()

        //This Print<T> method is genreic.
        //Students don't need to understand it at this point. Just use it as is.
        public static void Print<T>(IEnumerable<T> collection) { 
            Type typeOf = typeof(T);
            if (!(typeOf.IsPrimitive || typeOf.IsValueType || typeOf == typeof(string))) {
                Console.WriteLine("--------------------");
                var props = typeof(T).GetProperties();
                foreach (var prop in props)
                    Console.Write($"{prop.Name}\t");
                Console.WriteLine();
                foreach (var item in collection) {
                    foreach (var prop in props)
                        Console.Write($"{prop.GetValue(item, null)}\t");
                    Console.WriteLine();
                }
            }
            else { //Primitive types, Value types or strings:
                Console.WriteLine("--------------------");
                foreach (var item in collection)
                    Console.Write($"{item}\t");
                Console.Write("\n");
            }
        }

    }
}
