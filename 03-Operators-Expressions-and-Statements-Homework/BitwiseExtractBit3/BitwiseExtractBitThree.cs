using System;

class BitwiseExtractBitThree
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint nRightP = n >> 3;
        uint bit = nRightP & 1;
        Console.WriteLine(bit);
    }
}
