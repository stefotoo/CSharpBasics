using System;

class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object concatenatedObject = hello + " " + world;
        string concatenatedString = (string) concatenatedObject;
        Console.WriteLine(concatenatedString);
    }
}
