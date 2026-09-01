using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BookPractice
{
    public class ListDublicates
    {
        static void Main()
        {
            List<int> nums = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                nums.Add(rnd.Next(1, 6));
            }

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        nums.RemoveAt(j);
                        j--;
                    }
                }
            }

            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
    }
}