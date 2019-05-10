using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Classes;

namespace Workshop {

    class Program {

        static void Main(string[] args) {

            //Logger part - workshop part2
            Logger.ArchiveLog();
            Logger.DeleteLog();

            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-25),
                HireDate = new DateTime(2015, 10, 15),
                Title = "Hardware specialist",
                Email = "branko@gmail.com",
                Salary = 25000
            };
            //technician1.MaintainSystems();

            Accountant accountant = new Accountant {
                ID = 2,
                Name = "Petar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-25),
                HireDate = new DateTime(2015, 11, 5),
                Title = "Accountant",
                Email = "petar@gmail.com",
                Salary = 21000
            };
            //accountant.MaintainAccounts();

            Robot robot = new Robot {
                ID = 3,
                Name = "Robo",
                Surname = "Robo",
                BirthDate = DateTime.Now.AddYears(-5),
                HireDate = new DateTime(2015, 12, 5),
                Title = "Robot",
                Email = string.Empty,
                Salary = 0
            };
            //robot.MaintainDatawareHouse();

            Manager manager = new Manager {
                ID = 4,
                Name = "Aleksandar",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-46),
                HireDate = new DateTime(2015, 1, 5),
                Title = "Manager",
                Email = "aleksandar@gmail.com",
                Salary = 30000
            };
            manager.DoEmployeeApprisal(technician1);
            manager.PromoteEmployee(accountant);
            manager.SendCommunication();
            
            Director director = new Director {
                ID = 5,
                Name = "Violeta",
                Surname = "Markova",
                BirthDate = DateTime.Now.AddYears(-55),
                HireDate = new DateTime(2014, 4, 5),
                Title = "Director",
                Email = "violeta@gmail.com",
                Salary = 35000
            };
            //Console.WriteLine(director.ToString());
            director.PromoteEmployee(manager);
            

            //Workshop-Part2

            Action line = () => Console.WriteLine();

            //add some employees under manager
            Console.WriteLine("------------------");
            manager.AddSubEmployee(technician1);
            manager.AddSubEmployee(accountant);

            foreach (var e in manager.GetEmployees()) {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(manager.ToString());
            line();
            Console.WriteLine("------------------");

            manager.PromoteSubEmployees(9500);
            Console.WriteLine("Employees after promotion:");
            foreach (var e in manager.GetEmployees()) {
                Console.WriteLine(e.ToString());
            }
            line();
            //add some employees under director
            director.AddSubEmployee(manager);
            Console.WriteLine(director.ToString());
            Console.WriteLine("------------------");
            foreach (var e in director.GetEmployees()) {
                Console.WriteLine(e.ToString());
            }
            line();

            Manager manager2 = new Manager {
                ID = 6,
                Name = "Dimitar",
                Surname = "Petrov",
                BirthDate = DateTime.Now.AddYears(-26),
                HireDate = new DateTime(2019, 1, 5),
                Title = "Manager",
                Email = "dimitar@gmail.com",
                Salary = 30000
            };
            manager2.PromoteSubEmployees(5000);
            //See what's written in the Log.txt file
            
            
            director.SendCommunication();
            //See how async/await worked-out.

            //That's all
            Console.ReadLine();

        }
    }
}
