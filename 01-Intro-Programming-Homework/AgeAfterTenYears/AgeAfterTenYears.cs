using System;

class AgeAfterTenYears
{
    static void Main()
    {
        int age = new int();
        DateTime dateOfBirth = new DateTime();
        Console.WriteLine("Please enter your birthday in this format (YYYY-MM-DD): ");
        dateOfBirth = DateTime.Parse(Console.ReadLine());
        age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
        {
            age = age - 1;
        }
        Console.WriteLine("Your age is: {0}", age);
        Console.WriteLine("Your age after 10 years will be: {0}", (age + 10));
    }
}
