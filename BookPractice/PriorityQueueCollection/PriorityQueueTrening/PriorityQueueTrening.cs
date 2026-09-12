using System;
using System.Collections.Generic;

public class PriorityQueueTrening
{
    static void Main()
    {
        PriorityQueue<string, int> tren = new PriorityQueue<string, int>();

        tren.Enqueue("Помыть посуду", 3);
        tren.Enqueue("Сделать уроки", 1);
        tren.Enqueue("Поиграть в игры", 2);

        int i = 0;
        while (tren.Count > 0)
        {
            i++;
            Console.WriteLine($"Шаг {i}: " + tren.Dequeue());
        }
    }
}