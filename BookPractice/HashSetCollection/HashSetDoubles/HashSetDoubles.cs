using System;
using System.Collections.Generic;

public class HashSetDoubles
{
    static void Main()
    {
        List<int> rndNums = new List<int>();

        Random rnd = new Random();

        for (int i = 0; i < 15; i++)
        {
            rndNums.Add(rnd.Next(1, 6));
        }

        Console.Write("Рандомные числа из списка: ");
        foreach (int n in rndNums)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        HashSet<int> uNums = new HashSet<int>(rndNums);

        Console.WriteLine("Количество уникальных чисел: " + uNums.Count);
        Console.WriteLine("Уникальные числа: " + string.Join(", ", uNums));
    }
}