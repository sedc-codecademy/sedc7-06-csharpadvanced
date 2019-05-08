using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple {
    class Program {
        static void Main(string[] args) {
                        
            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "branko",
                Surname = "nikolov",
                BirthDate = DateTime.Now.AddYears(-35),
                Title = "Hardware specialist"
            };
            Console.WriteLine(technician1.ToString());
            Manager manager = new Manager {
                ID = 2,
                Name = "aleksandar",
                Surname = "nikolov",
                BirthDate = DateTime.Now.AddYears(-36),
                Title = "Manager"
            };
            Console.WriteLine(manager.ToString());

            Accountant accountant = new Accountant {
                ID = 3,
                Name = "violeta",
                Surname = "micova",
                BirthDate = DateTime.Now.AddYears(-45),
                Title = "Accountant"
            };
            Console.WriteLine(accountant.ToString());

            /*The not-good approach calls:            
            manager.DoEmployeeApprisalTechnical(technician1); // make an apprisal for this technician
            manager.PromoteEmployeeAccountant(accountant); // make a promotion for this accountant
            */

            manager.DoEmployeeApprisal(technician1); //technician1 is seen as Employee
            manager.PromoteEmployee(accountant); //accountant is seen as Employee

        }
    }
}
