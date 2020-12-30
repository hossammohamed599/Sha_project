using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class circle : Shape
    {
        double r;
        public double R
        {
            get => r;
            set
            {
                if (value > 0)
                {
                    r = value;
                }
            }
        }

        public circle(double w, double h, double r) : base(w, h)
        {
            R = r;
        }
        public double area()
        {
            return Math.PI * R * R;
        }
    }
}
