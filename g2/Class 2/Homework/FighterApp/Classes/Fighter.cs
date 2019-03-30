using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterApp.Classes
{
    public abstract class Fighter
    {
        public Fighter(double health, double powerPunch, double speed)
        {
            Health = health;
            PowerPunch = powerPunch;
            Speed = speed;
        }

        private double Health { get; set; }
        protected virtual double PowerPunch { get; set; }
        protected virtual double Speed { get; set; }

        public virtual void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public virtual void TakeDamage()
        {
            Health = 0;
        }

        public virtual bool IsDizzy()
        {
            if (Health < 10)
            {
                return true;
            }
            return false;
        }

        public abstract void Fight(Fighter opponent);
        protected abstract void Finisher(Fighter opponent);
    }
}
