using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's perimeter = " + ((width + height) * 2));
        Console.WriteLine("Rectangle's area = " + (width * height));
    }
}
