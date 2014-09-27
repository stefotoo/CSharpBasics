using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = p; i <= p + k; i++)
        {
            uint mask = 1;
            uint bitQ = (n & (mask << q)) >> q;
            uint bitP = (n & (mask << i)) >> i;

            n = n & ~(mask << i);
            n = n & ~(mask << q);

            n = n | (bitP << q);
            n = n | (bitQ << i);
            q++;
        }
        Console.WriteLine(n);

    }
}
