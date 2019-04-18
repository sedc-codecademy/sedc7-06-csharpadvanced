using System;
using TrainerStudentsApp.EventModels;

namespace TrainerStudentsApp.Models
{
    public delegate void AnnounceMarkEventHandler(object source, ExamMarkDetails args);

    public class Trainer
    {
        public event AnnounceMarkEventHandler AnnounceMark;
        protected internal void Announce(ExamMarkDetails studentMarkInfo)
        {
            Console.WriteLine($"Trainer: Student with id: {studentMarkInfo.Student.StudentID} - {studentMarkInfo.Student.FirstName} {studentMarkInfo.Student.LastName}, Points: {studentMarkInfo.Points}");

            AnnounceMark?.Invoke(this, studentMarkInfo);
        }
    }
}