using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1_2.Classes;

namespace Part1_2
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
                Title = "Hardware specialist"
            };
            Console.WriteLine("\n------------------------ Technician ------------------------");
            Console.WriteLine(technician1);
            technician1.MaintainSystems();

            Accountant accountant1 = new Accountant
            {
                ID = 2,
                Name = "Petar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-25),
                Title = "Accountant"
            };
            Console.WriteLine("\n------------------------ Accountant ------------------------");
            Console.WriteLine(accountant1);
            accountant1.MaintainAccounts();

            Robot robot1 = new Robot
            {
                ID = 3,
                Name = "Robo",
                Surname = "Robo",
                BirthDate = DateTime.Now.AddYears(-5),
                Title = "Robot"
            };
            Console.WriteLine("\n------------------------ Robot ------------------------");
            Console.WriteLine(robot1);
            robot1.MaintainDatawareHouse();

            Manager manager1 = new Manager
            {
                ID = 4,
                Name = "Aleksandar",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-46),
                Title = "Manager"
            };
            Console.WriteLine("\n------------------------ Manager ------------------------");
            Console.WriteLine(manager1);
            manager1.DoEmployeeApprisal(technician1);
            manager1.PromoteEmployee(accountant1);
            manager1.SendCommunication();

            Director director1 = new Director
            {
                ID = 5,
                Name = "Violeta",
                Surname = "Micova",
                BirthDate = DateTime.Now.AddYears(-55),
                Title = "Director"
            };
            Console.WriteLine("\n------------------------ Director ------------------------");
            Console.WriteLine(director1);
            director1.PromoteEmployee(manager1);
            director1.SendCommunication();

            Console.ReadLine();
        }
    }
}
