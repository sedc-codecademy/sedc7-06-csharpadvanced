using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adora
{
    public class PersonRepo
    {
        public Dictionary<string, Person> Students { get; set; }
        public Dictionary<string, Person> Lecturers { get; set; }

        private PersonRepo()
        {
            //Students = new Dictionary<string, Person>
            //{
            //    {"Emilija", new Student("Group 5", "Emilija", "Filiposka-Velichkovska") }
            //};
            //Lecturers = new Dictionary<string, Person>
            //{
            //    {"Weko", new Person("Wekoslav", "Stefanovski")}
            //};
        }

        static PersonRepo()
        {
            Group5.Students = new Dictionary<string, Person>
            {
                {"Emilija", new Student("Group 5", "Emilija", "Filiposka-Velichkovska") }
            };
            Group5.Lecturers = new Dictionary<string, Person>
            {
                {"Weko", new Person("Wekoslav", "Stefanovski")}
            };
        }

        public static PersonRepo Group5 = new PersonRepo();

    }
}
