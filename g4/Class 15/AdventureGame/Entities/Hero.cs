using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Hero
    {
        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if(value < 0)
                {
                    _health = 0;
                    return;
                }
                _health = value;
            }
        }
        private int _armor;
        public int Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                if (value < 0)
                {
                    _armor = 0;
                    return;
                }
                _armor = value;
            }
        }
        private int _food;
        public int Food
        {
            get
            {
                return _food;
            }
            set
            {
                if (value < 0)
                {
                    _food = 0;
                    return;
                }
                _food = value;
            }
        }
        public Hero()
        {
            Health = 60;
            Armor = 30;
            Food = 60;
        }
        public void TriggerEvent(Event ev)
        {
            if(ev.HealthModifier < 0 && Armor > 0)
            {
                Health += ev.HealthModifier - 5;
            } else
            {
                Health += ev.HealthModifier;
            }
            Armor += ev.ArmorModifier;
            Food += ev.FoodModifier;
            if(Food == 0)
            {
                Health -= 5;
            }
        }
        public void PrintStats()
        {
            Console.WriteLine("Hero stats:");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Armor: {Armor}");
            Console.WriteLine($"Food: {Food}");
        }
    }
}
