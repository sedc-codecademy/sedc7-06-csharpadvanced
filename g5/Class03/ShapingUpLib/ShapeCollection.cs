using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapingUpLib
{
    public class ShapeCollection
    {
        private List<IShape> shapes = new List<IShape>();

        public void AddShape(IShape shape)
        {
            shapes.Add(shape);
        }

        public double TotalPerimeter()
        {
            double sum = 0;
            foreach (var shape in shapes)
            {
                sum += shape.GetPerimeter();
            }
            return sum;
        }

        public double TotalArea()
        {
            double sum = 0;
            foreach (var shape in shapes)
            {
                sum += shape.GetArea();
            }
            return sum;
        }

        public int Count()
        {
            return shapes.Count;
        }



    }
}
