using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BookPractice
{
    public class StackDeep
    {
        static void Main()
        {
            string input = "((())())";

            Stack<char> deep = new Stack<char>();

            int maxDeepth = 0;

            foreach (char c in input)
            {
                if (c == '(')
                {
                    deep.Push('(');

                    if (deep.Count > maxDeepth)
                    {
                        maxDeepth = deep.Count;
                    }
                }
                else if (c == ')')
                {
                    deep.Pop();
                }
            }

            Console.WriteLine(maxDeepth);
        }
    }
}