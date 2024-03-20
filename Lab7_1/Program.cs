using System;

namespace Lab7_1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь треугольника: {0:F2}", GetTriangleArea(x, y, z));
            Console.ReadKey();
        }

        static double GetTriangleArea(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
    }
}
