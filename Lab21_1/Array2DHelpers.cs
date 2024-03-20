using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_1
{
    static class Array2DHelpers
    {
        static public int[,] FillArray(int m, int n)
        {
            Random random = new Random();
            int[,] result = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = random.Next(1, 99);
                }
            }

            return result;
        }

        static public void DisplayArray(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
