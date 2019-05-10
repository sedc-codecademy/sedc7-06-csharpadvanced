using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Part1.Classes;

namespace Workshop_Part1 {
    class Program {
        static void Main(string[] args) {

            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-25),
                HireDate = new DateTime(2015, 10, 15),
                Title = "Hardware specialist"
            };
            technician1.MaintainSystems();

            Accountant accountant = new Accountant {
                ID = 2,
                Name = "Petar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-25),
                HireDate = new DateTime(2016, 10, 20),
                Title = "Accountant"
            };
            accountant.MaintainAccounts();

            Robot robot = new Robot {
                ID = 3,
                Name = "Robo",
                Surname = "Robo",
                BirthDate = DateTime.Now.AddYears(-5),
                HireDate = new DateTime(2017, 05, 15),
                Title = "Robot"
            };
            robot.MaintainDatawareHouse();

            Manager manager = new Manager {
                ID = 4,
                Name = "Aleksandar",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-46),
                HireDate = new DateTime(2014, 10, 15),
                Title = "Manager"
            };
            manager.DoEmployeeApprisal(technician1);
            manager.PromoteEmployee(accountant);
            manager.SendCommunication();

            Director director = new Director {
                ID = 5,
                Name = "Violeta",
                Surname = "Markova",
                BirthDate = DateTime.Now.AddYears(-55),
                HireDate = new DateTime(2015, 01, 15),
                Title = "Director"
            };
            Console.WriteLine(director.ToString());
            director.PromoteEmployee(manager);
                       
        }
    }
}
