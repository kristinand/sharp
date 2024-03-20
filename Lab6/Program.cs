// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите предложение");
string[] str = Console.ReadLine().Split(' ');
string max = str[0];

foreach (string s in str)
{
    if (s.Length > max.Length)
    {
        max = s;
    }
}
Console.WriteLine(max);
Console.ReadKey();
