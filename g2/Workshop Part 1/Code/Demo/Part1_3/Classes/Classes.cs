using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1_3.Interfaces;

namespace Part1_3.Classes
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public override string ToString()
        {
            return $"{ID}. {Name} {Surname} - {Title}\t{BirthDate.ToString()}\t{HireDate.ToString()}";
        }
    }
    public class TechnicalStuff : Employee, IWorkable, IEatable
    {
        public void MaintainSystems()
        {
            Console.WriteLine("Technician maintains equipement.");
        }
        public void Work()
        {
            Console.WriteLine("Technician working ...");
        }
        public void Eat()
        {
            Console.WriteLine("Technician eating ...");
        }
    }
    public class Accountant : Employee, IEatable, IManageable
    {
        public void MaintainAccounts()
        {
            Console.WriteLine("TAccountant maintains accounts.");
        }
        public void Eat()
        {
            Console.WriteLine("Accountant eating ...");
        }
        public void Manage()
        {
            Console.WriteLine("Accountant manage accounts");
        }
    }
    public class Robot : Employee, IWorkable
    {
        public void MaintainDatawareHouse()
        {
            Console.WriteLine("Robot maintains data warehouse.");
        }
        public void Work()
        {
            Console.WriteLine("Robot working ...");
        }
    }
    public abstract class ManagementStuff : Employee, IManageable
    {
        public void DoEmployeeApprisal(Employee emp)
        {
            Console.WriteLine($"{emp.Name} has got an apprisal");
        }
        public void PromoteEmployee(Employee emp)
        {
            Console.WriteLine($"{emp.Name} has got a promotion");
        }
        public abstract void SendCommunication();
        public void Manage()
        {
            Console.WriteLine("ManagementStuff manageing ...");
        }
    }
    public class Manager : ManagementStuff
    {
        public override void SendCommunication()
        {
            Console.WriteLine("Message sent from the Manager");
        }
    }
    public class Director : ManagementStuff
    {
        public override void SendCommunication()
        {
            Console.WriteLine("Message sent from the Director");
        }
    }
}
