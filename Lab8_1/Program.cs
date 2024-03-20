using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        const string path = @"C:\MyFolder\Temp\";
        string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
        Console.ReadKey();
    }
}
