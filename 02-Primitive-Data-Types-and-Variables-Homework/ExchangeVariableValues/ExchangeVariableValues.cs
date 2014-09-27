using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("First initializing: a = {0}, b = {1}", a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("Exchange values: a = {0}, b = {1}", a, b);
    }
}
