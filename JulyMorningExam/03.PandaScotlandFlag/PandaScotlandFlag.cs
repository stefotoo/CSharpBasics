using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int flagSize = int.Parse(Console.ReadLine());
        char letter = 'A';

        for (int i = 1; i <= flagSize / 2 + 1; i++)
        {
            if (i == 1)
            {
                string firstLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;
                string hashes = new string('#', flagSize - 2);
                string secondLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;

                Console.WriteLine("{0}{1}{2}", firstLetter, hashes, secondLetter);
            }
            else if (i == flagSize / 2 + 1)
            {
                string middleLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;
                string dashes = new string('-', flagSize / 2);
                Console.WriteLine("{0}{1}{2}", dashes, middleLetter, dashes);
            }
            else if (i != flagSize / 2 + 1)
            {
                string brackets = new string('~', i - 1);
                string firstLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;
                string hashes = new string('#', flagSize - (brackets.Length * 2) - 2);
                string secondLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;

                Console.WriteLine("{0}{1}{2}{3}{4}", brackets, firstLetter, hashes, secondLetter, brackets);
            }
        }

        for (int i = flagSize / 2; i > 0; i--)
        {
            if (i == 0)
            {
                string firstLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;
                string hashes = new string('#', flagSize - 2);
                string secondLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;

                Console.WriteLine("{0}{1}{2}", firstLetter, hashes, secondLetter);
            }

            else
            {
                string brackets = new string('~', i - 1);
                string firstLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;
                string hashes = new string('#', flagSize - (brackets.Length * 2) - 2);
                string secondLetter = new string(letter, 1);
                letter = letterToA(letter);
                letter++;

                Console.WriteLine("{0}{1}{2}{3}{4}", brackets, firstLetter, hashes, secondLetter, brackets);
            }
        }
    }

    private static char letterToA(char letter)
    {
        if (letter.ToString() == "Z")
        {
            letter = '@';
        }
        return letter;
    }
}
