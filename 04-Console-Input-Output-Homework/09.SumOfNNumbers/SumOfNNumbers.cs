using System;

class SumOfNNumbers
{
    static void Main()
    {
        int n = -1;
        double sum = 0;
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        for (int i = 0; i < n; i++)
        {
            double a = double.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine(sum);
    }
}
