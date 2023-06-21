using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : _2DShape
    {
        double a, b, c;

        public override double GetPerimeter()
        {
            return a + b + c;
        }

        public override double GetSurfaceArea()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        public void SetA(double a) {
            this.a = a;
        }
        public void SetB(double b)
        {
            this.b = b;
        }
        public void SetC(double c)
        {
            this.c = c;
        }
        public double GetA()
        {
            return this.a;
        }
        public double GetB()
        {
            return this.b;
        }
        public double GetC()
        {
            return this.c;
        }

        public Triangle(double a, double b, double c) : this()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle()
        {
            SetName("Triangle");
            SetVerticesCount(3);   
        }
    }
}
