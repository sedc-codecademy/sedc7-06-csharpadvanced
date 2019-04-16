using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Subject
    {
        public string Title { get; set; }
        public int Modules { get; set; }
        public int StudentsAttending { get; set; }
        public Academy Type { get; set; }

        public Subject(string title, int modules, int students, Academy type)
        {
            Title = title;
            Modules = modules;
            StudentsAttending = students;
            Type = type;
        }
    }

    public enum Academy
    {
        Programming,
        Design,
        Networks
    }
}
