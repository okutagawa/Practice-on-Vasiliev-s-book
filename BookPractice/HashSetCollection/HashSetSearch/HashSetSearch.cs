using System;
using System.Collections.Generic;

public class HashSetSearch
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Гена",
            "Петя",
            "Степа",
            "Никита",
            "Даша",
            "Миша",
            "Гена",
            "Саша",
            "Петя",
            "Егор"
        };

        HashSet<string> uniNames = new HashSet<string>();

        foreach(string a in names)
        {
            if(!uniNames.Add(a))
            {
                Console.WriteLine("Первое имя-дубликат среди имен: " + a);
                Console.WriteLine(false);
                break;
            }

            uniNames.Add(a);
        }
    }
}