using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class ListShuffle
    {
        static void Main()
        {
            List<string> names = new() { "Дима", "Саша", "Витя", "Егор", "Петя" };

            Random rnd = new Random();

            WriteList(names);

            ShuffleList(names, rnd);

            WriteList(names);
        }

        static void ShuffleList(List<string> names, Random rnd)
        {
            string temp;
            for (int i = 0; i < names.Count; i++)
            {
                int j = rnd.Next(0, names.Count);
                
                temp = names[i];
                names[i] = names[j];
                names[j] = temp;
                
            }
        }

        static void WriteList(List<string> names)
        {
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}