using System;

namespace Lab22_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = FillArray(n);

            Func<object, int[]> func1 = new Func<object, int[]>(FillArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(GetSum);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetMaxValue);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();

            Console.WriteLine(string.Join(" ", task1.Result));
            Console.WriteLine($"Sum: {task2.Result}\nMax: {task3.Result}");

        }

        static public int[] FillArray(object val)
        {
            int n = (int)val;
            Random random = new Random();
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = random.Next(0, 20);  
            }
            return result;
        }

        static public int GetSum(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;
            foreach (int i in array) { sum += i; }
            return sum;

        }

        static public int GetMaxValue(Task<int[]> task) {
            int[] array = task.Result;
            int max = array[0];
            foreach (int i in array) { max = i > max ? i : max; }
            return max;
        }
    }
}
