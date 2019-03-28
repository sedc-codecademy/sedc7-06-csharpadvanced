using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp
{
    abstract class User
    {
        public Academy Academy { get; set; }
        public int ID { get; set; }
        public string Username { get; set; }

        public abstract string GetRole();

        public abstract IEnumerable<object> GetSomething();

        public override string ToString()
        {
            return Username;
        }
    }
}
