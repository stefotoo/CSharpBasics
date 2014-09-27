using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;
        Console.WriteLine("Int = {0} \nDouble = {1}", nullableInt, nullableDouble);
        nullableInt += 1;
        nullableDouble += 5;
        Console.WriteLine("Int = {0} \nDouble = {1}", nullableInt, nullableDouble);
    }
}
