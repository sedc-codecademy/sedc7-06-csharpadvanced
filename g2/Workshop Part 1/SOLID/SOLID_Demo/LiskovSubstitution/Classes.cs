using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution {
     

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
        public void SendCommunication(){} //this is a problem
    }

    public class Accountant : Employee {
        public void MaintainAccounts() { }
        public void SendCommunication(){} //this is a problem
    }

    public class Manager : Employee {
        //changing the methods parameters to Employee type
        public void DoEmployeeApprisal (Employee emploee) { }
        public void PromoteEmployee (Employee emploee) { }

        public void SendCommunication(){} //action allowed
    }

    public class Director : Employee {
        //changing the methods parameters to Employee type
        public void DoEmployeeApprisal(Employee emploee) { }
        public void PromoteEmployee(Employee emploee) { }

        public void SendCommunication() { } //action allowed
    }
    */
    #endregion

    /* Liskov substitution:
     * Def 1: A child class must be able to completely substitute and act-in for it’s base(parent) class.     
     * Def 2: A code that uses a base class must be able to substitute a subclass without knowing it.
     * Def 3: Functions that use pointers or references to base classes must be able to use objects of derived 
     * classes without knowing it.
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

    public abstract class ManagementStaff : Employee {
        public void DoEmployeeApprisal(Employee employee) {
            Console.WriteLine(employee.Name+" has got an apprisal");
        }
        public void PromoteEmployee(Employee employee) {
            Console.WriteLine(employee.Name + " has got a promotion");
        }

        // virtual or abstract memebers cannot be private
        public abstract void SendCommunication();
    }

    public class Manager : ManagementStaff {
        public override void SendCommunication() {
            Console.WriteLine("Message sent from the Manager");
        } //action allowed
    }

    public class Director : ManagementStaff { 
        public override void SendCommunication() {
            Console.WriteLine("Message sent from the Director");
        } //action allowed
    }
    #endregion

}
