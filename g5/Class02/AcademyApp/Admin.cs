using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Admin : User
    {
        public override string GetRole()
        {
            return "Administrator";
        }

        public IEnumerable<User> GetTeachers()
        {
            return Academy.Users.Where(u => u.GetRole() == "Teacher");
        }

        public override IEnumerable<object> GetSomething()
        {
            return Academy.Users.Where(u => u.GetRole() == "Student");
        }

    }
}
