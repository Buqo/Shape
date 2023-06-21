using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        int VerticesCount;
        string Name;

        protected Shape()
        {

        }

        public abstract double GetSurfaceArea();
        public string GetName()
        {

            return Name;
        }
        public int GetVerticesCount()
        {
            return VerticesCount;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetVerticesCount(int VerticesCount)
        {
            this.VerticesCount = VerticesCount;
        }

    }
}
