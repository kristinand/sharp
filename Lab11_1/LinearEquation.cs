using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1
{
    internal struct LinearEquation
    {
        private double k;
        private double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0)
            {
                return "Нет решений, т.к. k не может быть 0";
            }
            return  Convert.ToString(-b / k);
        }
    }
}
