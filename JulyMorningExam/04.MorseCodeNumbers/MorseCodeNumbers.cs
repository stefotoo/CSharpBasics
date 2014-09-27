using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = 0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (n < 1000 || n > 9999);
        string nString = n.ToString();
        int nSum = 0;
        for (int i = 0; i < 4; i++)
        {
            nSum += int.Parse(nString[i].ToString());
        }
            Console.WriteLine(nSum);
    }
}
