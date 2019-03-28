using System;
using System.Collections.Generic;

namespace Class2Demo
{
    public class Graphics
    {
        /// <summary>
        /// The parameter of this method is of type List of Shapes, so every element of this list
        /// is going to be a shape object or an object whos type derives from  the shape class.
        /// We iterate over this list of shapes, we may have a Circle as the first element
        /// of this list or the second element could be Rectanlge, so when we call the Draw method, even though
        /// we are talking about Shapes, at run time that shape can be a Circle,Rectangle,Triangle and for each 
        /// of them, the corresponding Draw method will be called. If its a Circle, the Draw method from Circle
        /// will be called and so on..
        /// </summary>
        /// <param name="shapes"></param>
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadLine();
        }
    }
}