using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class StackExample
    {
        static void Main()
        {
            Stack<int> nums = new Stack<int>();

            for (int i = 1; i <= 5; i++)
            {
                nums.Push(i);
            }

            while (nums.Count > 0)
            {
                Console.WriteLine(nums.Pop());
            }
        }
    }
}