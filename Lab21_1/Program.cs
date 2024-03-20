using System;

namespace Lab21_1
{
    internal class Program
    {
        const int g1Mark = -1;
        const int g2Mark = -2;
        const int m = 6;
        const int n = 6;
        static int[,] garden = Array2DHelpers.FillArray(m, n);


        static void Main(string[] args)
        {
            Array2DHelpers.DisplayArray(garden);
            

            ThreadStart threadStart = new ThreadStart(Gardener2);
            Thread th = new Thread(threadStart);
            th.Start();

            Gardener1();

            Array2DHelpers.DisplayArray(garden);
        }

        static void Gardener1()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int place = garden[i, j];
                    if (place != g2Mark)
                    {
                        Thread.Sleep(place);
                        garden[i, j] = g1Mark;
                    }
                }
            }
        }
        static void Gardener2()
        {
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    int place = garden[i, j];
                    if (place != g1Mark)
                    {
                        Thread.Sleep(place);
                        garden[i, j] = g2Mark;
                    }
                }
            }
        }
    }
}
