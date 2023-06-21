using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : _2DShape
    {
        double x, y;
        public override double GetPerimeter()
        {
            return 2 * (x + y);
        }

        public override double GetSurfaceArea()
        {
            return x * y;
        }
        public Rectangle()
        {
            this.SetName("Rectangle");
            this.SetVerticesCount(4);
        }

        protected Rectangle(string name)
        {
            this.SetName(name);
            this.SetVerticesCount(4);
        }
        public Rectangle(double x, double y) :this() 
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y) { 
            this.y = y;
        }
        public double GetX()
        {
                return this.x;

        }
        public double getY()
        {
                return this.y;
        }
    }
}
