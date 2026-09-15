using System;
using System.Collections.Generic;

public class HashSetTesting
{
    static void Main()
    {
        HashSet<int> nums = new HashSet<int> { 1, 2, 2, 3, 4 };

        Console.WriteLine("Количество элементов в хэш-сет: " + nums.Count);

        Console.WriteLine("Элементы: " + string.Join(", ", nums));  
    }
}