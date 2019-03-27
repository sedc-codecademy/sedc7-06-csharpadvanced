using System.Collections.Generic;

namespace Class2Demo
{
    public class Graphics
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}