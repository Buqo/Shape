using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class ShapeList
    {
        List<Shape> shapes = new();

        public void Add(Shape shape)
        {
            Console.WriteLine(shape.ToString());
            shapes.Add(shape);
        }
        public void GetShapeAtIndex(int pos)
        {
            try
            {
                Shape shp= shapes[pos];
                Console.WriteLine(shp);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(pos);
                Console.WriteLine($"{e.Message}");
            }
        }
        public void RemoveShapeAtIndex(int pos)
        {
            try
            {
                shapes.RemoveAt(pos);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
