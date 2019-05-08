using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation {

    #region Bad approacch
    /*
    //The bad approach for the IWorker interface in the classes:
    public interface IWorker {
        void Work();
        void Eat();
        //What if someone adds here another method that is not required for every class implementing IWorker?
    }

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

    public class TechnicalStuff : Employee, IWorker {
        public void MaintainSystems() { }

        public void Work() {
            Console.WriteLine("Technician Working...");
        }
        public void Eat() {
            Console.WriteLine("Technician Eating...");
        }
    }

    public class Accountant : Employee, IWorker {
        public void MaintainAccounts() { }

        public void Work() {
            Console.WriteLine("Accountant Working...");
        }
        public void Eat() {
            Console.WriteLine("Accountant Eating...");
        }
    }

    public class Robot : Employee, IWorker {
        public void MaintainDatawareHouse() { }

        public void Work() {
            Console.WriteLine("Robot Working...");
        }
        public void Eat() { //Robot doesn't need this method 
            Console.WriteLine("Robot Eating...");
        }
    }

    public abstract class ManagementStaff : Employee, IWorker {
        public void DoEmployeeApprisal(Employee employee) {
            Console.WriteLine(employee.Name+" has got an apprisal");
        }
        public void PromoteEmployee(Employee employee) {
            Console.WriteLine(employee.Name + " has got a promotion");
        }

        public void Work() {
            Console.WriteLine("Mng Stuff Working...");
        }
        public void Eat() {
            Console.WriteLine("Mng Stuff Eating...");
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
    */
    #endregion
    
     /*
     * A client should never be forced to implement a function that it does not require. 
     * Instead of having bloated interfaces, segregate them based on roles.
     * This rule means that when one class depends upon another, the number of members in the 
     * interface that is visible to the dependent class should be minimised.
     */

    #region Good approach
    public interface IWorkable {
        void Work(); 
    }
    public interface IEatable {
        void Eat();
    }
    public interface IManageble {
        void Manage();
    }

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

    public class TechnicalStuff : Employee, IWorkable, IEatable {
        public void MaintainSystems() { }

        public void Work() {
            Console.WriteLine("Technician Working...");
        }
        public void Eat() {
            Console.WriteLine("Technician Eating...");
        }
    }

    public class Accountant : Employee, IEatable,IManageble {
        public void MaintainAccounts() { }

        public void Manage() {
            Console.WriteLine("Accountant managing...");
        }
        public void Eat() {
            Console.WriteLine("Accountant Eating...");
        }
    }

    public class Robot : Employee, IWorkable {
        public void MaintainDatawareHouse() { }

        public void Work() {
            Console.WriteLine("Robot Working...");
        } 
    }

    public abstract class ManagementStaff : Employee, IManageble {

        public void DoEmployeeApprisal(Employee employee) {
            Console.WriteLine(employee.Name + " has got an apprisal");
        }
        public void PromoteEmployee(Employee employee) {
            Console.WriteLine(employee.Name + " has got a promotion");
        }

        public void Manage() {
            Console.WriteLine("Mng Stuff Working...");
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
