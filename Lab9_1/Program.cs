// See https://aka.ms/new-console-template for more information
try
{
    Console.Write("Введите целое число x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите целое число y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите код операции: \n\t 1 - сложение \n\t 2 - вычитание \n\t 3 - произведение \n\t 4 - частное ");
    byte operation = Convert.ToByte(Console.ReadLine());

    if (operation < 1 || operation > 4)
    {
        throw new Exception("Код операции должен принимать целое значение от 1 до 4");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
