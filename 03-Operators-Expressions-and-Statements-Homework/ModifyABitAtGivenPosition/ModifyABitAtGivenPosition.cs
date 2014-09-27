using System;

class ModifyABitAtGivenPosition
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bitV = int.Parse(Console.ReadLine());
        if (bitV == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }

    }
}
