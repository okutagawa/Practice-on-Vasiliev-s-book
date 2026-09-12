using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueMessage
    {
        static void Main()
        {
            Queue<string> messages = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "print")
                {
                    if (messages.Count > 0)
                    {
                        Console.WriteLine(messages.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Очередь пуста.");
                    }
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Выход.");
                    break;
                }
                else
                {
                    messages.Enqueue(input);
                    Console.WriteLine("В очередь было добавлено слово: " + input);
                }
            }
        }
    }
}