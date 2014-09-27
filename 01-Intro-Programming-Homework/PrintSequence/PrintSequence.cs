using System;

class PrintSequence
{
    static void Main()
    {
        int num = 0;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 != 0)
            {
                num = num - i;
                Console.Write(num + " ");
                num = 0;
            }
            if (i % 2 == 0)
            {
                num = num + i;
                Console.Write(num + " ");
                num = 0;
            }
        }
    }
}
