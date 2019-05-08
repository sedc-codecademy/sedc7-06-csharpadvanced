using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple {

    #region Bad approach
    /*  
    public class TechnicalStuff {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }

        //employee does this
        public void MaintainSystems() { }

        //manager does this for the employee
        public void DoEmployeeApprisal(TechnicalStuff ts1) { }
        public void PromoteEmployee(TechnicalStuff ts1) { }

        public override string ToString() {
            return ID + " " + Name + " " + Surname + " " + Title + " " + BirthDate.ToString("yyyy-mm-dd");  
        }
    }
    */

    #endregion

    /*
     * Single Responsibility Principle:
     * One class should only have one responsibility and it should be able to execute it well.
     * This doesn't mean that a class should have only one method. It can have more methods, but the major resposiblity
     * of the objects of that class is strictly known.  
     */

    //Code refactoring and good example

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

    public class Manager : Employee {
        public void DoEmployeeApprisal(TechnicalStuff ts1) { }
        public void PromoteEmployee(TechnicalStuff ts1) { }
    }
    #endregion

}
