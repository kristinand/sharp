using Lab20_1;


Console.WriteLine("Введите радиус: ");
double CircleRadius = Convert.ToDouble(Console.ReadLine());

MyDelegate myDelegate1 = Circle.GetCircumference;
Console.WriteLine("Длина окружности: {0:F2}", myDelegate1(CircleRadius));

myDelegate1 = Circle.GetSquare;
Console.WriteLine("Площадь круга: {0:F2}", myDelegate1(CircleRadius));

myDelegate1 = Circle.GetVolume;
Console.WriteLine("Объем шара: {0:F2}", myDelegate1(CircleRadius));
