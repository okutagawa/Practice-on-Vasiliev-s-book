using System;
using System.Collections.Generic;

public class PriorityQueueSame
{
    static void Main()
    {
        PriorityQueue<string, int> samePeople = new PriorityQueue<string, int>();

        samePeople.Enqueue("Иван", 1);
        samePeople.Enqueue("Мария", 1);
        samePeople.Enqueue("Петр", 1);
        samePeople.Enqueue("Гриша", 1);
        samePeople.Enqueue("Лиза", 1);
        samePeople.Enqueue("Митя", 1);
        samePeople.Enqueue("Боря", 1);

        while (samePeople.Count > 0)
        {
            Console.WriteLine(samePeople.Dequeue());
        }
    }
}