namespace LinqDemo
{
    public class Course
    {
        public int Semester { get; set; }
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }
        public CourseType Type { get; set; }

        public Course(int semester, string name, int numberOfClasses, CourseType type)
        {
            Semester = semester;
            Name = name;
            NumberOfClasses = numberOfClasses;
            Type = type;
        }
    }

    public enum CourseType
    {
        Fe,
        Be
    }
}
