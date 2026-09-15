using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class StackReverse
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> letters = new Stack<char>();

            foreach (char text in input)
            {
                letters.Push(text);
            }

            string reversed = "";

            while (letters.Count > 0)
            {
                reversed += letters.Pop();
            }

            Console.WriteLine(reversed);
        }
    }
}