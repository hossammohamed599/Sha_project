using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Shape
    {
        double width;
        double height;

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }
}   }
