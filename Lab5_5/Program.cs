// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размерность");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) ? 1 : 0;
        Console.WriteLine("{0} ", matrix[i, j]);
    }
    Console.WriteLine();
}
Console.ReadKey();
