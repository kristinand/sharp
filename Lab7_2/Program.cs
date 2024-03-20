using System;

namespace Lab7_2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetCubeParams(a, out v, out s);

            Console.WriteLine("Объем куба: {0:F2}; площадь поверхности: {1:F2}",v,s);
            Console.ReadKey();
        }

        static void GetCubeParams(double a, out double v, out double s)
        {
            s = 6 * Math.Pow(a,2);
            v= Math.Pow(a, 3);
        }
    }
}
