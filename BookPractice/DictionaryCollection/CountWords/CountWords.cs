using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class CountWords
    {
        static void Main()
        {
            string[] text = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var w in words)
            {
                Console.WriteLine("Слово " + w.Key + " встречается: " + w.Value + " раз(-а).");
            }
        }
    }
}