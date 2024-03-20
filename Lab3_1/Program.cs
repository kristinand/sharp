using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Введите координаты трех вершин прямоугольника");
        int aX = Convert.ToInt32(Console.ReadLine());
        int aY = Convert.ToInt32(Console.ReadLine());
        int bX = Convert.ToInt32(Console.ReadLine());
        int bY = Convert.ToInt32(Console.ReadLine());
        int cX = Convert.ToInt32(Console.ReadLine());
        int cY = Convert.ToInt32(Console.ReadLine());

        if (!((aX == bX || aX == cX || bX == cX) && (aY == bY || aY == cY || bY == cY))) {
            Console.WriteLine("Нельзя получить прямоульник со сторонами, параллельными координатным осям, по даннм координатам");
        } else {
            int dX = aX == bX ? cX : aX == cX ? bX : aX;
            int dY = aY == bY ? cY : aY == cY ? bY : aY;
            Console.WriteLine("{0},{1}", dX, dY);
        }

        Console.ReadLine();
        }
    }
}
