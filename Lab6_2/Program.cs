// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите предложение");
string str = Console.ReadLine().ToLower().Replace(" ", "");
int strLength = str.Length;
bool palindromic = false;

for (int i = 0; i < strLength / 2; i++)
{
    if (str[i] == str[strLength - i - 1])
    {
        palindromic = true;
    }
    else
    {
        palindromic = false;
        break;
    }
}

Console.WriteLine(palindromic ? "Это палиндром" : "Это не палиндром");
Console.ReadKey();
