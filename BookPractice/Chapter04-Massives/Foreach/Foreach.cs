using System;

namespace BookPractice;

class Foreach
{
    static void Main()
    {
        int[] nums = { 1, 3, 4, 8, 9 };

        char[] symbs = { 'a', 'b', 'A', 'B', 'Ы' };

        string[] txts = { "красный", "желтый", "синий" };

        Console.WriteLine("Целочисленный массив: ");

        foreach (int i in nums)
        {
            Console.WriteLine("Число {0} - {1}", i, i % 2 == 0 ? "четное" : "нечетное");
        }
        Console.WriteLine();

        Console.WriteLine("Символьный массив: ");

        foreach (char i in symbs)
        {
            Console.WriteLine("Код символа {0} - {1}", i, (int)i);
        }
        Console.WriteLine();

        Console.WriteLine("Текстовый массив: ");

        foreach (string i in txts)
        {
            Console.WriteLine("В слове \"{0}\" {1} букв", i, i.Length);
        }
        Console.WriteLine();
    }
}