using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        const string filePath = @"C:\MyFolder\Temp\File.txt";
        File.Create(filePath).Close();

        StreamWriter sw = new StreamWriter(filePath);

        for(int i =0;i< 10;i++)
        {
            Random random = new Random();
            sw.WriteLine(random.Next(-10,10));
        }

        sw.Close();

        StreamReader sr = new StreamReader(filePath);
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
           int number = Convert.ToInt32(sr.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}
