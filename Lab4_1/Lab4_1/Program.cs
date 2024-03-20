// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

int square = 0;

for (int i = 1; i <= N; i++)
{
    square += 2 * i - 1;
    Console.WriteLine(square);
}
Console.ReadKey();
