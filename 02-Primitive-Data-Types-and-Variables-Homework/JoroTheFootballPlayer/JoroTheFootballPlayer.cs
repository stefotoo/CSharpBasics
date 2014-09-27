using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int hometownWeekends = int.Parse(Console.ReadLine());
        int plays = 0;

        plays += hometownWeekends;
        plays += (52 - hometownWeekends) * 2 / 3;
        plays += numberOfHolidays / 2;
        if (leap == "t")
        {
            plays += 3;
        }

        Console.WriteLine(plays);
    }
}

