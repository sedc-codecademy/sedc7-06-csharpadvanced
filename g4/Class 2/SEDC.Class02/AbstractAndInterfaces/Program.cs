using AbstractAndInterfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getters setters
            //Human bobi = new Human();
            //bobi.FullName = "Boban Radovanovich";
            //bobi.Age = 29;
            //Console.WriteLine(bobi.Age);
            //bobi.Age = 33;
            //Console.WriteLine(bobi.Age);
            //Console.ReadLine();

            //Employee Greg = new Employee(); // will not work
            Developer bob = new Developer()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Id = 342,
                ProgrammingLanugages = new List<string>() { "C#", "JS", "HTML", "CSS" }
            };
            Tester jill = new Tester()
            {
                FirstName = "Jill",
                LastName = "Wayne",
                Id = 456,
                BugsFound = 233
            };
            bob.PrintEmployee();
            bob.ChangePosition(Job.CEO);
            bob.Code();
            jill.PrintEmployee();
            jill.Talk();
            jill.ChangePosition(Job.Developer);
            jill.FindBug();

            Employee greg = new Developer();
            List<Employee> employees = new List<Employee>();
            employees.Add(bob);
            employees.Add(jill);

            Console.ReadLine();
        }
    }
}
