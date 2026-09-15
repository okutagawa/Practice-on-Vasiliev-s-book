using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class StackPalindrome
    {
        static void Main()
        {
            Stack<char> text = new Stack<char>();

            string input = Console.ReadLine();

            char[] charArr = input.ToArray();

            foreach (char a in input)
            {
                text.Push(a);
            }

            // string reverse = "";

            bool isPalindrome = true;

            for (int i = 0; i < text.Count; i++)
            {
                if (charArr[i] != text.Pop())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("Палиндром.");
            }
            else
            {
                Console.WriteLine("Не палиндром.");
            }
        }
    }
}