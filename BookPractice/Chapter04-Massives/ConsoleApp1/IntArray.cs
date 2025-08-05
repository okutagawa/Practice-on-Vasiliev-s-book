using System;

namespace BookPractice;

class IntArray
{
    static void Main()
    {
        int[] nums = new int[12];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i*3+1; // формула для вычисления чисел, которые при делении на число А дают в остатке число Б
            Console.Write("| " + nums[i] + " ");
        }
        Console.WriteLine("|");
    }
}