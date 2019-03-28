using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    class Student: User
    {
        public override string GetRole()
        {
            return "Student";
        }

        public void Enroll()
        {

        }

        public override IEnumerable<object> GetSomething()
        {
            throw new NotImplementedException();
        }
    }
}
