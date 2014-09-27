using System;

class Trapezoids
{
    static void Main()
    {
        double a = Math.Abs(double.Parse(Console.ReadLine()));
        double b = Math.Abs(double.Parse(Console.ReadLine()));
        double h = Math.Abs(double.Parse(Console.ReadLine()));
        double area = (a + b) * h / 2;
        Console.WriteLine(area);
    }
}
