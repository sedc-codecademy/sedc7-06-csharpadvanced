namespace Class2Demo
{
    /// <summary>
    /// Class that will be used as a base class for more concrete types of shapes,
    /// for example Triangle, Rectangle that will inherit the functionalities 
    /// provided by this class
    /// </summary>
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }

        public Shape()
        {

        }

        public Shape(int height, int width, string color)
        {
            Height = height;
            Width = width;
            Color = color;
        }

        /// <summary>
        /// Virtual method that can be redefined in derived classes. In our example we dont have 
        /// any implementation inside. 
        /// </summary>
        public virtual void Draw()
        {
        }
    }
}