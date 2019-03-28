using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Admin : HumanUser
    {
        public override string GetRole()
        {
            return "Administrator";
        }

        public IEnumerable<IUserLike> GetTeachers()
        {
            return Academy.Users.Where(u => u.GetRole() == "Teacher");
        }

        public override IEnumerable<object> GetSomething()
        {
            return Academy.Users.Where(u => u.GetRole() == "Student");
        }

    }
}
