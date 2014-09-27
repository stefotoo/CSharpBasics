using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        bool isSeven = (number / 100) % 10 == 7;
        Console.WriteLine(isSeven);
    }
}
