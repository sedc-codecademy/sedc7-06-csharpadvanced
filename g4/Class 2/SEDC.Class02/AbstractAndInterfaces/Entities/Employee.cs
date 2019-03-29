using AbstractAndInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces.Entities
{
    public abstract class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Job Position { get; protected set; }
        public void ChangePosition(Job position)
        {
            Console.WriteLine($"You have changed position from {Position} to {position}!");
            Position = position;
        }
        public abstract void PrintEmployee();
    }   
    public enum Job
    {
        Developer,
        CEO,
        Tester,
        Designer
    }
}
