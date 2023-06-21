using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square :Rectangle
    {
        public Square() : base()
        {
            SetName("Square");
        }
        public void SetX(double x)
        {
            base.SetX(x);
            base.SetY(x);
        }
        public override double GetPerimeter()
        {
            return base.GetPerimeter();
        }

        public Square(double x) : base(x,x)
        {
            SetName("Square");
        }
    }
}
