// See https://aka.ms/new-console-template for more information
using Lab15_1;

ArithProgression ar = new ArithProgression(2);

ar.SetStart(1);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(ar.GetNext());
}

ar.Reset();
Console.WriteLine(ar.GetNext());

Console.WriteLine("\n***\n");

GeomProgression gp = new GeomProgression(2);

gp.SetStart(1);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(gp.GetNext());
}

gp.Reset();
Console.WriteLine(gp.GetNext());
