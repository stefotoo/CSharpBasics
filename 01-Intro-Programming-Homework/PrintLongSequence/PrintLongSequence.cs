using System;

class PrintLongSequence
{
    static void Main()
    {
        int num = 0;
        for (int i = 2; i < 1002; i++)
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
