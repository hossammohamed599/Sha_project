using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h)
        {

        }
        public double area()
        {
            return Width * Height;
        }
    }
}
