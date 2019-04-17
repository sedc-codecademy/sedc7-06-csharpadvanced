using System;
using TrainerStudentsApp.EventModels;

namespace TrainerStudentsApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(int id, string firstName, string lastName)
        {
            StudentID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void ListenTrainerAnnouncement(object source, ExamMarkDetails markInfo)
        {
            if (markInfo.Student.StudentID.Equals(StudentID))
            {
                if (markInfo.Points < 50)
                {
                    Console.WriteLine("Oh no, I failed the exam. :( ");
                }
                else
                {
                    Console.WriteLine("Great, I have passed the exam! :) ");
                }
            }
        }
    }
}