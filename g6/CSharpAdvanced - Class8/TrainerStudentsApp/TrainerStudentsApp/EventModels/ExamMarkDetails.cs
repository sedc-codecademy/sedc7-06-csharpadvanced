using System;
using TrainerStudentsApp.Models;

namespace TrainerStudentsApp.EventModels
{
    public class ExamMarkDetails : EventArgs
    {
        public Student Student{ get; set; }
        public int Points { get; set; }
    }
}