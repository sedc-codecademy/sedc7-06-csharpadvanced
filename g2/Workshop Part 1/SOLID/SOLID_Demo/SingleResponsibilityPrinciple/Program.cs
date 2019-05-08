using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple {
    class Program {
        static void Main(string[] args) {

            #region Bad approach
            /* Instantiating from a Bad example
            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "branko",
                Surname = "nikolov",
                BirthDate = DateTime.Now.AddYears(-35),
                Title = "Hardware specialist"
            };
            Console.WriteLine(technician1.ToString());

            //the employee cannot itself do apprisal and promotion ;)
            */
            #endregion

            //The good example

            #region Good approach
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
                Title = "Hardware manager"
            };
            Console.WriteLine(manager.ToString());
            manager.DoEmployeeApprisal(technician1); // make an apprisal for this employee
            manager.PromoteEmployee(technician1); // make a promotion for this employee
            #endregion

        }
    }
}
