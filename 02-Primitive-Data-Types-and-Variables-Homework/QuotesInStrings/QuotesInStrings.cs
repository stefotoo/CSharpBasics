using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstMethod = "The \"use\" of quotations causes difficulties.";
        string secondMethod = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("First method: {0} \nSecond method: {1}", firstMethod, secondMethod);
    }
}
