using System;
using System.Collections.Generic;

public class HashSetUnik
{
    static void Main()
    {
        HashSet<int> nums = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (!nums.Add(input))
            {
                Console.WriteLine("Это число уже было!");
            }
        }

        Console.WriteLine("Количество уникальных чисел: " + nums.Count);
        Console.WriteLine("Числа: " + string.Join(", ", nums));
    }
}