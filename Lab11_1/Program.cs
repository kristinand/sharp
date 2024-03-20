namespace Lab11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            LinearEquation eq = new LinearEquation(k,b);

            Console.WriteLine("Значение уравнения 0={0}x{1:+0;-0;+0}: {2}", k,b,eq.Root());
        }
    }
}
