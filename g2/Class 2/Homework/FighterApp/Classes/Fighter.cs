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

        /// <summary>
        /// Takes an amount of damage from an opponent
        /// </summary>
        /// <param name="damage">Amount of damage to be taken</param>
        public virtual void TakeDamage(double damage)
        {
            Health -= damage;
        }

        /// <summary>
        /// Takes all the damage from an opponent
        /// </summary>
        public virtual void TakeDamage()
        {
            Health = 0;
        }

        /// <summary>
        /// Checks if opponent is dizzy, if he is then Finisher method should be called.
        /// </summary>
        /// <returns>true/false wether the opponent is dizzy or not</returns>
        public virtual bool IsDizzy()
        {
            if (Health < 10)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// All opponent's health should be taken and it should Console.Write a finishing style and recovery time in weeks(hard-coded for each fighter)
        /// </summary>
        /// <param name="opponent">An opponent to finish</param>
        protected abstract void Finisher(Fighter opponent);
    }
}
