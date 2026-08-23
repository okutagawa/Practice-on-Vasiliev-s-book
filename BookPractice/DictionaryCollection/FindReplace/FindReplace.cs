using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class FindReplace
    {
        static void Main()
        {
            Dictionary<string, string> words = new()
            {
                {"привет", "здравствуйте" },
                {"Привет", "Здравствуйте" },
                {"пока", "до свидания" },
                {"Пока", "До свидания" },
                {"спс", "спасибо" },
                {"пж", "пожалуйста" },
            };

            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                if (words.ContainsKey(input[i]))
                {
                    input[i] = words[input[i]];
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}