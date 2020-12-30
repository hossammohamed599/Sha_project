using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    
        class Table_circle_cost : circle
        {
            double cost_meter;


            public Table_circle_cost(double w, double h, double r, double c) : base(w, h, r)
            {
                cost_meter = c;
            }
            public double Cost_meter { get => cost_meter; set => cost_meter = value; }
            public double total_cost()
            {
                double price = cost_meter * area();
                return price;
            }
        }
    
}
