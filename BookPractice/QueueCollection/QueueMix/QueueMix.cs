using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueMix
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();

            names.Enqueue("Миша");
            names.Enqueue("Дима");
            names.Enqueue("Саша");
            names.Enqueue("Костя");
            names.Enqueue("Никита");

            List<string> mixNames = new List<string>();

            Random rnd = new Random();

            mixNames = names.ToList();

            ShuffleList(mixNames, rnd);

            WriteList(mixNames);
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