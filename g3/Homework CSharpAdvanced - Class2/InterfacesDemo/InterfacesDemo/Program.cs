using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPredator shark = new Fish() { AttackSpeed = 30, Name = "Shark" };
            IPray pinguin = new Fish() { FleeSpeed = 25, Name = "Pinguin" };
            IPray herring = new Fish() { FleeSpeed = 35, Name = "Herring" };
            shark.Attack(pinguin);
            shark.Attack(herring);
        }
    }
}
