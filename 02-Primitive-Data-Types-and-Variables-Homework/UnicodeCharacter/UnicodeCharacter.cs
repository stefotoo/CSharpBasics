using System;
using System.Text;

class UnicodeCharacter
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char symbol = '\u002A';
        Console.WriteLine(symbol);
    }
}
