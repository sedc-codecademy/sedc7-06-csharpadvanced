using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    interface IUserLike
    {
        Academy Academy { get; set; }
        int ID { get; set; }
        string Username { get; set; }

        IEnumerable<object> GetSomething();
        string GetRole();
    }
}
