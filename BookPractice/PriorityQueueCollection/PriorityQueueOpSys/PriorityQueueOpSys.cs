using System;
using System.Collections.Generic;

public class PriorityQueueOpSys
{
    static void Main()
    {
        PriorityQueue<string, int> process = new PriorityQueue<string, int>();

        process.Enqueue("Браузер", 3);
        process.Enqueue("Стим", 4);
        process.Enqueue("Игра", 1);
        process.Enqueue("Дискорд", 2);
        process.Enqueue("Текстовый файл", 6);
        process.Enqueue("Телеграмм", 5);

        while (process.TryDequeue(out string processName, out int processPriority))
        {
            Console.WriteLine($"Выполняется: {processName} (приоритет [{processPriority}])");
            if (processPriority < 10)
            {
                processPriority++;
                process.Enqueue(processName, processPriority);
            }
        }
    }
}