namespace Lab10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градус, минуты и секунды для угла");
            int gradus = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());

            Degree degree = new Degree(gradus, min, sec);

            Console.WriteLine("Введенный угол {0}°{1}'{2}“ в радианах: {3} ", degree.Gradus, degree.Min, degree.Sec, degree.ToRad());
            Console.ReadKey();
        }
    }
}
