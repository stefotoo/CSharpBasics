﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:0.###}|", a, (Convert.ToString(a, 2)), b, c);
    }
}
