using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part2_8.Interfaces;

namespace Part2_8.Classes
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public string GratitudeText { get; set; }
        public string CongratulationText { get; set; }
        public override string ToString()
        {
            return $"{ID}. {Name} {Surname} - {Title}\t{BirthDate.ToString()}\t{HireDate.ToString()}\t{Email}\t{Salary}";
        }

        public void Subscribe(ManagementStuff ms)
        {
            ms.EmployeeOfTheMonth +=
                new ManagementStuff.EventHandler(manageableStuff_EmployeeOfTheMonth);
        }
        public void manageableStuff_EmployeeOfTheMonth(object sender, EventArgs e)
        {
            EmployeeEventArgs eea = (EmployeeEventArgs)e;
            if (eea.Name == this.Name)
            {
                Console.WriteLine($"{this.Name}: {GratitudeText}");
            }
            else
            {
                Console.WriteLine($"{this.Name}: {CongratulationText} {eea.Name}");
            }
        }
    }
    public class TechnicalStuff : Employee, IWorkable, IEatable
    {
        public void MaintainSystems()
        {
            Console.WriteLine("Technician maintains equipement.");
            Logger.Log("Technician maintains equipement.");
        }
        public void Work()
        {
            Console.WriteLine("Technician working ...");
            Logger.Log("Technician working ...");
        }
        public void Eat()
        {
            Console.WriteLine("Technician eating ...");
            Logger.Log("Technician eating ...");
        }
    }
    public class Accountant : Employee, IEatable, IManageable
    {
        public void MaintainAccounts()
        {
            Console.WriteLine("Accountant maintains accounts.");
            Logger.Log("Accountant maintains accounts.");
        }
        public void Eat()
        {
            Console.WriteLine("Accountant eating ...");
            Logger.Log("Accountant eating ...");
        }
        public void Manage()
        {
            Console.WriteLine("Accountant manage accounts");
            Logger.Log("Accountant manage accounts");
        }
    }
    public class Robot : Employee, IWorkable
    {
        public void MaintainDatawareHouse()
        {
            Console.WriteLine("Robot maintains data warehouse.");
            Logger.Log("Robot maintains data warehouse.");
        }
        public void Work()
        {
            Console.WriteLine("Robot working ...");
            Logger.Log("Robot working ...");
        }
    }
    public class EmployeeEventArgs : EventArgs
    {
        public string Name { get; set; }
    }
    public abstract class ManagementStuff : Employee, IManageable
    {
        public void DoEmployeeApprisal(Employee emp)
        {
            Console.WriteLine($"{emp.Name} has got an apprisal");
            Logger.Log($"{emp.Name} has got an apprisal");
        }
        public void PromoteEmployee(Employee emp)
        {
            Console.WriteLine($"{emp.Name} has got a promotion");
            Logger.Log($"{emp.Name} has got a promotion");
        }
        public abstract void SendCommunication();
        public void Manage()
        {
            Console.WriteLine("ManagementStuff manageing ...");
            Logger.Log("ManagementStuff manageing ...");
        }
        private List<Employee> _employees = new List<Employee>();
        public void AddSubEmployee(Employee e)
        {
            _employees.Add(e);
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
        public string EmailList
        {
            get { return string.Join(";", _employees.Select(e => e.Email)); }
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Email list: " + EmailList;
        }
        public void PromoteSubEmployees(int totalPromotionAmount)
        {
            try
            {
                double equalPortion = totalPromotionAmount / _employees.Count;
                foreach (Employee e in _employees)
                {
                    e.Salary += equalPortion;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Zero employees under manager: " + ex.Message, LogType.Error);
            }
        }

        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler EmployeeOfTheMonth;
        public void PromoteEmployeeOfTheMonth(Employee e)
        {
            Console.WriteLine($"{this.Name}: Employee of the month is {e.Name}");

            if (EmployeeOfTheMonth != null)
            {
                EmployeeEventArgs employeeInfo = new EmployeeEventArgs() { Name = e.Name };
                EmployeeOfTheMonth(this, employeeInfo);
            }
        }
    }
    public class Manager : ManagementStuff
    {
        public override async void SendCommunication()
        {
            Console.WriteLine("Message sent from the Manager");
            Logger.Log("Message sent from the Manager");
            string msg = await SendCommunicationAsync();
            Console.WriteLine(msg);
            Logger.Log(msg);
        }
        private static async Task<string> SendCommunicationAsync()
        {
            //await Task.Delay(8000);
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(8000);
            });

            return "Async task finished for Manager";
        }
    }
    public class Director : ManagementStuff
    {
        public override async void SendCommunication()
        {
            Console.WriteLine("Message sent from the Director");
            Logger.Log("Message sent from the Director");
            string msg = await SendCommunicationAsync();
            Console.WriteLine(msg);
            Logger.Log(msg);
        }
        private static async Task<string> SendCommunicationAsync()
        {
            //await Task.Delay(5000);
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
            });

            return "Async task finished for Director";
        }
    }
}
