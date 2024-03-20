using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружности");
            double l  = Convert.ToDouble(Console.ReadLine());

            double r = l / (2 * Math.PI);
            double S = Math.Pow(l,2) / (4 * Math.PI);

            Console.WriteLine("Радиус {0:f2}", r);
            Console.WriteLine("Площадь {0:f2}", S);
            Console.ReadLine();
        }
    }
}
