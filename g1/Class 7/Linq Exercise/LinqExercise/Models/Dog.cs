namespace LinqExercise.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, Color color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }
    }
}