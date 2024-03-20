// See https://aka.ms/new-console-template for more information
const int N = 7;
int[] a = new int[N];

int sum = 0;
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите число {0}:", i + 1);
    a[i] = Convert.ToInt32(Console.ReadLine());
    sum += a[i];
}
Console.WriteLine(((double)sum) / N);
Console.ReadKey();
