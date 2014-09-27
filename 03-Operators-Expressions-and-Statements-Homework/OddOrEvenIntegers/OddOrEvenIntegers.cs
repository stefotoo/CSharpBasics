using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        bool isOdd = false;
        int n = int.Parse(Console.ReadLine());
        if (n % 2 != 0)
        {
            isOdd = true;
            Console.WriteLine(isOdd);
        }
        else
        {
            isOdd = false;
            Console.WriteLine(isOdd);
        }
    }
}
