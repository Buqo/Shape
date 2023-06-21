using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class _2DShape : Shape
    {
        public abstract double GetPerimeter();
        public override string ToString()
        {
            return $"Name of the figure: {GetName()}\nNumber of vertices: {GetVerticesCount()}\nPerimeter of the figure: {GetPerimeter()}\n" +
                $"Area of the figure: {GetSurfaceArea()}";
        }
    }

}
