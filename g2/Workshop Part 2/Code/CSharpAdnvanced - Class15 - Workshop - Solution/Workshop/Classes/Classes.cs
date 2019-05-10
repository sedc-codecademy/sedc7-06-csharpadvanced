using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Interfaces;

namespace Workshop.Classes {

    public abstract class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; } = string.Empty;
        public double Salary { get; set; }

        //you can implement virtual methods inside abstract class
        public override string ToString() {
            //return ID + " " + Name + " " + Surname + " " + Title + " " + BirthDate.ToString("yyyy-mm-dd") + " " + Email+" "+Salary;
            return $"{ID}\t{Name}\t{Surname}\t{Title}\t{BirthDate}\t{HireDate}\t{Email}\t{Salary}\t";
        }
    }

    public class TechnicalStuff : Employee, IWorkable, IEatable {
        public void MaintainSystems() {
            //Console.WriteLine("Technician maintains equipement.");
            Logger.Log("Technician maintains equipement.");
        }
        public void Work() {
            //Console.WriteLine("Technician Working...");
            Logger.Log("Technician Working...");
        }
        public void Eat() {
            //Console.WriteLine("Technician Eating...");
            Logger.Log("Technician Eating...");
        }
    }

    public class Accountant : Employee, IEatable, IManageable {
        public void MaintainAccounts() {
            //Console.WriteLine("Accountant does general ledger booking.");
            Logger.Log("Accountant does general ledger booking.");
        }
        public void Manage() {
            //Console.WriteLine("Accountant managing...");
            Logger.Log("Accountant managing...");
        }
        public void Eat() {
            //Console.WriteLine("Accountant Eating...");
            Logger.Log("Accountant Eating...");
        }
    }

    public class Robot : Employee, IWorkable {
        public void MaintainDatawareHouse() {
            //Console.WriteLine("Robot does risky stuff.");
            Logger.Log("Robot does risky stuff.");
        }
        public void Work() {
            //Console.WriteLine("Robot Working...");
            Logger.Log("Robot Working...");
        }
    }

    public abstract class ManagementStaff : Employee, IManageable {

        public void DoEmployeeApprisal(Employee employee) {
            //Console.WriteLine(employee.Name + " has got an apprisal");
            Logger.Log(employee.Name + " has got an apprisal");
        }

        public void PromoteEmployee(Employee employee) {
            //Console.WriteLine(employee.Name + " has got a promotion");
            Logger.Log(employee.Name + " has got a promotion");
        }
               
        public void Manage() {
            //Console.WriteLine("Management Stuff Working...");
            Logger.Log("Management Stuff Working...");
        }

        // virtual or abstract memebers cannot be private
        public abstract void SendCommunication();

        //Part2
        private List<Employee> _employees = new List<Employee>();

        public void AddSubEmployee(Employee e) {
            _employees.Add(e);
        }

        public IEnumerable<Employee> GetEmployees() {
            return _employees;
        }

        public string EmailList {
            get { return string.Join(";", _employees.Select(e => e.Email)); ; }
        }

        public override string ToString() {
            return base.ToString() + " Email list: " + EmailList;
        }

        public void PromoteSubEmployees(int totalPromotionAmount) {
            try {
                double equalPortion = totalPromotionAmount / _employees.Count;
                foreach (var e in _employees) {
                    e.Salary += equalPortion;
                }
            }
            catch (Exception ex) {
                Logger.Log("Zero employees under manager: " + ex.Message, LogType.Error);
            }
        }

    }

    public class Manager : ManagementStaff {
        //Part2
        public override async void SendCommunication() {
            //Console.WriteLine("Message sent from the Manager");
            string msg = await ProcessCommunication();
            Logger.Log(msg);

        }
        //Part2
        private static async Task<string> ProcessCommunication() {
            await Task.Delay(8000);
            return "async task finished for Manager";
        }
    }

    public class Director : ManagementStaff {
        //Part2
        public override async void SendCommunication() {
            //Console.WriteLine("Message sent from the Director");
            string msg = await ProcessCommunication();
            Logger.Log(msg);
        }
        //Part2
        private static async Task<string> ProcessCommunication() {
            await Task.Delay(5000);
            return "async task finished for Director";
        }
    }
}
