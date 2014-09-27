using System;

class NumbersFromOneToN
{
    static void Main()
    {
        int n = -1; 
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
