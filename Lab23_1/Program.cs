using System;

namespace Lab23_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            GetFactorialAsync(n);
            Console.ReadKey();
        }

        static int GetFactorial(int n)
        {
            Thread.Sleep(100);
            if (n == 0 || n == 1) { return 1; };
            return GetFactorial(n - 1) * n;
        }

        static async Task GetFactorialAsync(int n)
        {
            int result = await Task.Run(() => GetFactorial(n));
            Console.WriteLine("{0:0,0}", result);
        }
    }
}
