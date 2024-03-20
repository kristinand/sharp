using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberName = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            Console.WriteLine("Введите возраст от 20 до 69");
            int age = Convert.ToInt16(Console.ReadLine());

            int decade = age / 10;
            int remainder = age % 10;
            string result = Convert.ToString(age);
            result += " — ";
            switch (decade)
            {
                case 1:
                case 2:
                case 3:
                    {
                        result += numberName[decade] + "дцать";
                        break;
                    };
                case 4:
                    {
                        result += "сорок";
                        break;
                    }
                default:
                    {
                        result += numberName[decade] + "десят";
                        break;
                    }
            }
            result += remainder == 0 ? "" : " " + numberName[remainder];
            Console.WriteLine(result);
        }
    }
}
