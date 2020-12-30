using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Rectangle_Cost : Rectangle
    {
        double total_meter;
        public Rectangle_Cost(double w, double h, double c) : base(w, h)
        {
            total_meter = c;
        }

        public double Total_meter { get => total_meter; set => total_meter = value; }
        public double price()
        {
            double total_cost = total_meter * base.area();
            return total_cost;
        }
    }
}
