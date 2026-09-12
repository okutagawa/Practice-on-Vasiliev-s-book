using System;
using System.Collections.Generic;

public class PriorityQueueSearch
{
    static void Main()
    {
        PriorityQueue<string, int> tasks = new PriorityQueue<string, int>();

        tasks.Enqueue("Помыть посуду", 3);
        tasks.Enqueue("Поиграть в компьютер", 4);
        tasks.Enqueue("Сделать уроки", 1);
        tasks.Enqueue("Почитать книгу", 2);

        while (tasks.TryDequeue(out string element, out int priority))
        {
            Console.WriteLine($"Задача: {element}, приоритет {priority}");
        }
    }
}