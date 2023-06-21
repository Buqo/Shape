using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : _2DShape
    {
        double r;
        const double pi = 3.14;
        public override double GetPerimeter()
        {
            return r * 2 * pi;
        }

        public override double GetSurfaceArea()
        {
            return pi * r * r;
        }
        public Circle()
        {
            this.SetName("Circle");
            this.SetVerticesCount(0);
        }

        public Circle(int r) :this()
        {
            this.r = r;
        }
        public double GetRadius()
        {
            return r;
        }
        public void SetRadius(double r)
        {
            this.r = r;
        }
    }
}
