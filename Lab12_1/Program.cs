namespace Lab12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.GetCircumference(4.2));
            Console.WriteLine(Circle.GetSquare(4.2));
            Console.WriteLine(Circle.IsPointInCircle(1,1,0,0,3));
            Console.WriteLine(Circle.IsPointInCircle(1, 1, 0, 0, 0.3));
        }
    }
}
