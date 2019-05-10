using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_1.Classes
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
            Console.WriteLine("Accountant maintains accounts.");
        }
    }
    public class Robot : Employee
    {
        public void MaintainDatawareHouse()
        {
            Console.WriteLine("Robot maintains data warehouse.");
        }
    }
    public class Manager : Employee
    {
        public void DoEmployeeApprisal(Employee emp)
        {
            Console.WriteLine($"Manager: {emp.Name} has got an apprisal");
        }
        public void PromoteEmployee(Employee emp)
        {
            Console.WriteLine($"Manager: {emp.Name} has got a promotion");
        }
    }
    public class Director : Employee
    {
        public void DoEmployeeApprisal(Employee emp)
        {
            Console.WriteLine($"Director: {emp.Name} has got an apprisal");
        }
        public void PromoteEmployee(Employee emp)
        {
            Console.WriteLine($"Director: {emp.Name} has got a promotion");
        }
    }
}
