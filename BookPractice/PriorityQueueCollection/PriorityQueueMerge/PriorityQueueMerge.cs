using System;
using System.Collections.Generic;

public class PriorityQueueMerge
{
    static void Main()
    {
        PriorityQueue<string, int> queue1 = new PriorityQueue<string, int>();
        PriorityQueue<string, int> queue2 = new PriorityQueue<string, int>();

        queue1.Enqueue("Помыть посуду", 2);
        queue1.Enqueue("Сделать уроки", 1);
        queue1.Enqueue("Погулять", 3);
        queue1.Enqueue("Посмотреть фильм", 4);

        queue2.Enqueue("Поиграть в компьютер", 5);
        queue2.Enqueue("Покушать", 6);
        queue2.Enqueue("Принять душ", 7);
        queue2.Enqueue("Пойти спать", 8);

        PriorityQueue<string, int> queue3 = new PriorityQueue<string, int>();

        while (queue1.TryDequeue(out string task, out int priority))
        {
            queue3.Enqueue(task, priority);
        }

        while (queue2.TryDequeue(out string qTask, out int qPriority)) 
        {
            queue3.Enqueue(qTask, qPriority);
        }

        while (queue3.TryDequeue(out string t, out int p))
        {
            Console.WriteLine(t + " " + p);
        }
    }
}