using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1
{
    static class Circle
    {
        public static double GetCircumference(double r)
        {
            return 2.0*Math.PI*r;
        }

        public static double GetSquare(double r)
        {
            return Math.PI * Math.Pow(r,2);
        }

        public static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Sqrt(Math.Pow(x-x0, 2) + Math.Pow(y-y0, 2)) <= r;
        }

    }
}
