using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_Part1.Interfaces;

namespace Workshop_Part1.Classes {

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
        public void MaintainSystems() {
            Console.WriteLine("Technician maintains equipement.");           
        }
        public void Work() {
            Console.WriteLine("Technician Working...");
        }
        public void Eat() {
            Console.WriteLine("Technician Eating...");
        }
    }

    public class Accountant : Employee, IEatable, IManageable {
        public void MaintainAccounts() {
            Console.WriteLine("Accountant does general ledger booking.");
        }
        public void Manage() {
            Console.WriteLine("Accountant managing...");
        }
        public void Eat() {
            Console.WriteLine("Accountant Eating...");
        }
    }
         
    public class Robot : Employee, IWorkable {
        public void MaintainDatawareHouse() {
            Console.WriteLine("Robot does risky stuff.");
        }
        public void Work() {
            Console.WriteLine("Robot Working...");
        }
    }
    
    public abstract class ManagementStaff : Employee, IManageable {

        public void DoEmployeeApprisal(Employee employee) {
            Console.WriteLine(employee.Name + " has got an apprisal");
        }
        public void PromoteEmployee(Employee employee) {
            Console.WriteLine(employee.Name + " has got a promotion");
        }

        public void Manage() {
            Console.WriteLine("Management Stuff Working...");
        }

        // virtual or abstract memebers cannot be private
        public abstract void SendCommunication();
    }

    public class Manager : ManagementStaff {
        public override void SendCommunication() {
            Console.WriteLine("Message sent from the Manager");
        }
    }

    public class Director : ManagementStaff {
        public override void SendCommunication() {
            Console.WriteLine("Message sent from the Director");
        }
    }


}
