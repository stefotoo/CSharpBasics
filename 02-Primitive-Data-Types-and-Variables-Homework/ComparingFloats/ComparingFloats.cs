using System;


class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter number a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b:");
        double b = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        if (a > b)
        {
            if (a - b > eps)
            {
                Console.WriteLine("The two number are not equal with precision 0.000001");
            }
            else
            {
                Console.WriteLine("The two number are equal with precision 0.000001");
            }
        }
        else if (b > a)
        {
            if (b - a > eps)
            {
                Console.WriteLine("The two number are not equal with precision 0.000001");
            }
            else
            {
                Console.WriteLine("The two number are equal with precision 0.000001");
            }
        }
    }
}
