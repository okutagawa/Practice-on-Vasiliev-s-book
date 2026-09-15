using System;
using System.Collections.Generic;

public class HashSetText
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        HashSet<string> words = new HashSet<string>(input);

        Console.WriteLine("Список уникальных слов: \n" + string.Join("\n", words));

    }
}