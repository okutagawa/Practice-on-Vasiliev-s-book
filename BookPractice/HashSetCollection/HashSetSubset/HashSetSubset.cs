using System;
using System.Collections.Generic;

public class HashSetSubset
{
    static void Main()
    {
        HashSet<int> small = new HashSet<int> { 1, 3, 5 };
        HashSet<int> big = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine("Является ли множество small поднмножеством множества big? " + small.IsSubsetOf(big));
    }
}