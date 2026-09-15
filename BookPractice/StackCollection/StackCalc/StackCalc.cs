using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BookPractice
{
    public class StackCalc
    {
        static void Main()
        {
            string[] input = "3 4 + 5 *".Split(' ');

            Stack<int> nums = new Stack<int>();



            foreach (string a in input)
            {
                int n;
                if (int.TryParse(a, out n)) 
                {
                    nums.Push(n);
                }
                else if (a == "+")
                {
                    int fNum = nums.Pop();
                    int sNum = nums.Pop();
                    int result = fNum + sNum;
                    nums.Push(result);
                }
                else if (a == "-")
                {
                    int fNum = nums.Pop();
                    int sNum = nums.Pop();
                    int result = sNum - fNum;
                    nums.Push(result);
                }
                else if (a == "*")
                {
                    int fNum = nums.Pop();
                    int sNum = nums.Pop();
                    int result = fNum * sNum;
                    nums.Push(result);
                }
                else if (a == "/")
                {
                    int fNum = nums.Pop();
                    int sNum = nums.Pop();
                    int result = sNum / fNum;
                    nums.Push(result);
                }
            }

            Console.WriteLine("Результат вычисления = " + nums.Peek());
        }
    }
}