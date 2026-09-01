using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BookPractice
{
    public class ListRandomNumbers
    {
        static void Main()
        {
            Random rnd = new Random();

            List<int> numbers = new List<int>();

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rnd.Next(1, 50));
                sum += numbers[i];
            }

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n" + sum);
        }
    }
}