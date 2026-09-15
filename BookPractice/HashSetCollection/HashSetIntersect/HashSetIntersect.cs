using System;
using System.Collections.Generic;

public class HashSetIntersect
{
    static void Main()
    {
        HashSet<int> fNums = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> sNums = new HashSet<int> { 4, 5, 6, 7, 8 };


        HashSet<int> numbers = new HashSet<int>(fNums);

        numbers.IntersectWith(sNums);

        Console.WriteLine("Результат пересечения двух хеш-сетов: " + string.Join(", ", numbers));
    }
}