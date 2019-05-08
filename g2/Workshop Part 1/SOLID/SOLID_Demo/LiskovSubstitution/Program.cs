using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution {
    class Program {
        static void Main(string[] args) {

            #region Bad approach
            //Not the right-way classes design:
            //TechnicalStuff technical = new TechnicalStuff();
            //technical.SendCommunication();
            #endregion
            
            //SendCommunication() requires implementation in every class, redundancy is possible.
            //Apart that, the maintenance of the x-fold code is needed also.
            //SendCommunication is only needed for the Managers and above (Director, Vice president, ...)
            //It needs to be implemented with minimum coding
            //It's not wise to put the SendCommunication() method in the Employee abstract class as a virtual method

            #region Good approach
            //The right-way classes-design:
            Manager manager = new Manager();
            manager.SendCommunication();

            Director director = new Director();
            director.SendCommunication();

            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-35),
                Title = "Hardware specialist"
            };
            manager.DoEmployeeApprisal(technician1);

            Accountant accountant = new Accountant {
                ID = 3,
                Name = "Violeta",
                Surname = "Micova",
                BirthDate = DateTime.Now.AddYears(-45),
                Title = "Accountant"
            };
            director.PromoteEmployee(accountant);

            #endregion

        }
    }
}
