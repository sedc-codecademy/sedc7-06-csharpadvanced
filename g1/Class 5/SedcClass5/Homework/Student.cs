using System;

namespace Homework
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void Hear(string name, int mark)
        {
            if (name == Name)
            {
                Console.WriteLine(mark > 5 ? $"{Name}: Jas poloziv." : $"{Name}: Jas padnav.");
            }
        }
    }
}
