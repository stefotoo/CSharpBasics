using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = -1;
        int sum = 0;
        int previous = 0;
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
        } while (n <= 0);

        for (int i = 0; i <= n; i++)
        {
            previous = sum;
            sum += i;
            Console.Write(sum + " ");
        }
    }
}
