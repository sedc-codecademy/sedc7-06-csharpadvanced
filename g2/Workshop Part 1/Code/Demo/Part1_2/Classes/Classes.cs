using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_2.Classes
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
    public class TechnicalStuff : Employee
    {
        public void MaintainSystems()
        {
            Console.WriteLine("Technician maintains equipement.");
        }
    }
    public class Accountant : Employee
    {
        public void MaintainAccounts()
        {
            Console.WriteLine("TAccountant maintains accounts.");
        }
    }
    public class Robot : Employee
    {
        public void MaintainDatawareHouse()
        {
            Console.WriteLine("Robot maintains data warehouse.");
        }
    }
    public abstract class ManagementStuff : Employee
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
