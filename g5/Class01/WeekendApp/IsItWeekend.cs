using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendApp
{
    class IsItWeekend
    {
        public bool Resolve(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return false;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return true;
            }
            throw new ApplicationException("Invalid day of week");
        }

        public bool this[DayOfWeek dayOfWeek] {
            get
            {
                return Resolve(dayOfWeek);
            }
        }


    }
}