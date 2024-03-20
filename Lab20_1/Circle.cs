using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_1
{
    static class Circle
    {
        public static double GetCircumference(double r) => 2.0 * Math.PI * r;
        public static double GetSquare(double r) => Math.PI * Math.Pow(r, 2);
        public static double GetVolume(double r) => 4 / 3.0 * Math.PI * Math.Pow(r, 3);
    }

    public delegate double MyDelegate(double r);
}
