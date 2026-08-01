using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BookPractice
{
    public class ListStrings
    {
        static void Main()
        {
            string input = "";

            List<string> strings = new List<string>();

            while (input != "stop")
            {
                strings.Add(input = Console.ReadLine());
            }
            Console.WriteLine("\n");

            strings.Remove("stop");
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}