namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainer = new Trainer();
            var student1 = new Student("Risto");
            var student2 = new Student("Trajan");

            trainer.EventHandler += student1.Hear;
            trainer.EventHandler += student2.Hear;

            trainer.Announce("Risto", 5);
            trainer.Announce("Trajan", 8);
            trainer.Announce("Nekoj", 6);
        }
    }
}
