using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part2_4.Classes;

namespace Part2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalStuff technician1 = new TechnicalStuff
            {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-25),
                Title = "Hardware specialist",
                Email = "branko@gmail.com",
                Salary = 25000
            };
            Console.WriteLine("\n------------------------ Technician ------------------------");
            Console.WriteLine(technician1);
            technician1.MaintainSystems();
            technician1.Work();
            technician1.Eat();

            Accountant accountant1 = new Accountant
            {
                ID = 2,
                Name = "Petar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-25),
                Title = "Accountant",
                Email = "petar@gmail.com",
                Salary = 21000
            };
            Console.WriteLine("\n------------------------ Accountant ------------------------");
            Console.WriteLine(accountant1);
            accountant1.MaintainAccounts();
            accountant1.Eat();
            accountant1.Manage();

            Robot robot1 = new Robot
            {
                ID = 3,
                Name = "Robo",
                Surname = "Robo",
                BirthDate = DateTime.Now.AddYears(-5),
                Title = "Robot",
                Email = string.Empty,
                Salary = 0
            };
            Console.WriteLine("\n------------------------ Robot ------------------------");
            Console.WriteLine(robot1);
            robot1.MaintainDatawareHouse();
            robot1.Work();

            Manager manager1 = new Manager
            {
                ID = 4,
                Name = "Aleksandar",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-46),
                Title = "Manager",
                Email = "aleksandar@gmail.com",
                Salary = 30000
            };
            Console.WriteLine("\n------------------------ Manager ------------------------");
            manager1.DoEmployeeApprisal(technician1);
            manager1.PromoteEmployee(accountant1);
            manager1.SendCommunication();
            manager1.Manage();
            manager1.AddSubEmployee(technician1);
            manager1.AddSubEmployee(accountant1);
            Console.WriteLine(manager1);
            foreach (Employee e in manager1.GetEmployees())
            {
                Console.WriteLine(e);
            }
            
            Director director1 = new Director
            {
                ID = 5,
                Name = "Violeta",
                Surname = "Micova",
                BirthDate = DateTime.Now.AddYears(-55),
                Title = "Director",
                Email = "violeta@gmail.com",
                Salary = 35000
            };
            Console.WriteLine("\n------------------------ Director ------------------------");
            director1.PromoteEmployee(manager1);
            director1.SendCommunication();
            director1.Manage();
            director1.AddSubEmployee(manager1);
            Console.WriteLine(director1);
            foreach (Employee e in director1.GetEmployees())
            {
                Console.WriteLine(e);
            }
            
            Console.ReadLine();
        }
    }
}
