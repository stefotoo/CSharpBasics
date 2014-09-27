using System;

class DivideBy7And5
{
    static void Main()
    {
        bool isDivideBy7and5 = false;
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0 && number % 7 == 0)
        {
            isDivideBy7and5 = true;
            Console.WriteLine(isDivideBy7and5);
        }
        else
        {
            isDivideBy7and5 = false;
            Console.WriteLine(isDivideBy7and5);
        }
    }
}
