using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class RepeatLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters.Add(letter, 1);
                }
            }

            foreach (var let in letters)
            {
                Console.WriteLine(let.Key + ": " + let.Value);
            }
        }
    }
}