namespace Class2Demo
{
    /// <summary>
    /// Abstract class Shape that is partially defined class that cannot be instantiated. 
    /// It (usually) includes some implementation,
    /// but leaves some functions as pure virtual-declared only by their signature
    /// </summary>
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }

        public Shape(int height, int width, string color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        /// <summary>
        ///  If you don't provide a constructor for your class, 
        ///  C# creates one by default that instantiates the object
        ///  and sets member variables to the default value. But in our case, above we
        ///  create a contructor with parameters, so we need to add the default one also.
        /// </summary>
        public Shape()
        {

        }

        /// <summary>
        /// Abstract methods are without implemnetation, any class that derives from Shape,
        /// will need to provide an implementation for this method. Otheriwse, will get
        /// compiple time error.
        /// </summary>
        public abstract void Draw();
    }
}