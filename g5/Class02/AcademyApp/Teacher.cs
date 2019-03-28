using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Teacher: User
    {
        public override string GetRole()
        {
            return "Teacher";
        }

        public override IEnumerable<object> GetSomething()
        {
            throw new NotImplementedException();
        }
    }
}
