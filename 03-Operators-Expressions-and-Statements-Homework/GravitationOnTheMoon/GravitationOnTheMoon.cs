using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weightOnEarth = double.Parse(Console.ReadLine());
        Console.WriteLine("Weight on moon is " + (weightOnEarth * 0.17));
    }
}
