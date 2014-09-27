using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int melonsCount = 0;
        int watermelonsCount = 0;
        int enteredDay = int.Parse(Console.ReadLine());
        int daysAmount = int.Parse(Console.ReadLine());
        int i = 0;

        while (i < daysAmount)
        {
            if (enteredDay == 1)
            {
                watermelonsCount = watermelonsCount + 1;
            }
            else if (enteredDay == 2)
            {
                melonsCount = melonsCount + 2;
            }
            else if (enteredDay == 3)
            {
                melonsCount = melonsCount + 1;
                watermelonsCount = watermelonsCount + 1;
            }
            else if (enteredDay == 4)
            {
                watermelonsCount = watermelonsCount + 2;
            }
            else if (enteredDay == 5)
            {
                watermelonsCount = watermelonsCount + 2;
                melonsCount = melonsCount + 2;
            }
            else if (enteredDay == 6)
            {
                watermelonsCount = watermelonsCount + 1;
                melonsCount = melonsCount + 2;
            }
            else
            {
                enteredDay = 0;
            }
            enteredDay++;
            i++;
        } 
        
       

        if (watermelonsCount == melonsCount)
        {
            Console.WriteLine("Equal amount: {0}", watermelonsCount);
        } 
        else if (watermelonsCount > melonsCount)
        {
            Console.WriteLine("{0} more watermelons", (watermelonsCount - melonsCount));
        }
        else
        {
            Console.WriteLine("{0} more melons", (melonsCount - watermelonsCount));
        }

    }
}
