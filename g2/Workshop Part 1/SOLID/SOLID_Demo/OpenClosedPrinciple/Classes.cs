using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple {
     

    #region Bad approach
    //Not a good solution yet
    /*
    public abstract class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }

        // you can implement virtual methods inside abstract class
        public override string ToString() {
            return ID + " " + Name + " " + Surname + " " + Title + " " + BirthDate.ToString("yyyy-mm-dd");
        }
    }

    public class TechnicalStuff : Employee {
        public void MaintainSystems() { }
    }

    public class Accountant : Employee {
        public void MaintainAccounts() { }
    }

    public class Manager : Employee {
        public void DoEmployeeApprisalTechnical(TechnicalStuff ts1) { }
        public void PromoteEmployeeTechnical(TechnicalStuff ts1) { }

        //adding new functionality
        public void DoEmployeeApprisalAccountant(Accountant accountant) { }
        public void PromoteEmployeeAccountant(Accountant accountant) { }
    }
    */

    #endregion

    /* Open-Closed Principle:
     *  Software entities should be Open for extension, but Closed for modification.
        Modules should allow for extensions to add new features without affecting existing code to make sure 
        the changes are confined to a smaller part of code and new bugs are not introduced to existing code.
     */

    #region Good approach
    public abstract class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }

        // you can implement virtual methods inside abstract class
        public override string ToString() {
            return ID + " " + Name + " " + Surname + " " + Title + " " + BirthDate.ToString("yyyy-mm-dd");
        }
    }

    public class TechnicalStuff : Employee {
        public void MaintainSystems() { }
    }

    public class Accountant : Employee {
        public void MaintainAccounts() { }
    }

    public class Manager : Employee {
        //changing the methods parameters to Employee type
        public void DoEmployeeApprisal (Employee emploee) { }
        public void PromoteEmployee (Employee emploee) { } 
    }
    #endregion

}
