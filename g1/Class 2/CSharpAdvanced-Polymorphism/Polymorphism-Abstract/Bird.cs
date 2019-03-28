namespace Polymorphism_Abstract
{
    internal class Bird : Animal
    {
        public override bool Feathers { get; set; } = true;

        public override string Describe()
        {
            return "This is the Birds ";
        }
        public override string Features()
        {
            return "Can fly.";
        }
        public override bool HasFeathers()
        {
            return Feathers;
        }
        //You cannot declare an abstract method outside an abstract class 
    }
}