using System.Collections.Generic;
using TrainerStudentsApp.EventModels;
using TrainerStudentsApp.Models;

namespace TrainerStudentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new Trainer();
            var student1 = new Student(1, "Miodrag", "Cekikj");
            var student2 = new Student(2, "Andrej", "Chichakovski");
            var student3 = new Student(3, "Trajan", "Stevkovski");

            var examResults = new List<ExamMarkDetails>()
            {
                new ExamMarkDetails(){ Student = student1, Points = 65},
                new ExamMarkDetails(){ Student = student2, Points = 75},
                new ExamMarkDetails(){ Student = student3, Points = 15}
            };

            trainer.AnnounceMark += student1.ListenTrainerAnnouncement;
            trainer.AnnounceMark += student2.ListenTrainerAnnouncement;
            trainer.AnnounceMark += student3.ListenTrainerAnnouncement;

            foreach (var result in examResults)
            {
                trainer.Announce(result);
            }
        }
    }
}