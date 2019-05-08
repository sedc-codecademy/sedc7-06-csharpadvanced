using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation {
    class Program {
        static void Main(string[] args) {

            #region Bad approach
            /*
            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-35),
                Title = "Hardware specialist"
            };
            technician1.Work();
            technician1.Eat();

            Manager manager = new Manager();
            manager.Work();
            manager.Eat();

            Robot robot = new Robot();
            robot.Eat();
            robot.Work();
            */
            #endregion

            #region Good approach
            TechnicalStuff technician1 = new TechnicalStuff {
                ID = 1,
                Name = "Branko",
                Surname = "Nikolov",
                BirthDate = DateTime.Now.AddYears(-35),
                Title = "Hardware specialist"
            };
            technician1.Work();
            technician1.Eat();

            Manager manager = new Manager();
            manager.Manage();

            Accountant accountant = new Accountant {
                ID = 3,
                Name = "Violeta",
                Surname = "Micova",
                BirthDate = DateTime.Now.AddYears(-45),
                Title = "Accountant"
            };
            accountant.Eat();

            Robot robot = new Robot();
            //robot.Eat();
            robot.Work();
            #endregion

        }
    }
}
