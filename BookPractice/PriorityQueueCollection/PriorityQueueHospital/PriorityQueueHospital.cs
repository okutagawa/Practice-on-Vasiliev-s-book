using System;
using System.Collections.Generic;

public class PriorityQueueHospital
{
    static void Main()
    {
        PriorityQueue<string, int> hospital = new PriorityQueue<string, int>();

        hospital.Enqueue("Простуда", 4);
        hospital.Enqueue("Перелом", 2);
        hospital.Enqueue("Инфаркт", 1);
        hospital.Enqueue("Ушиб", 3);
        hospital.Enqueue("Отравление", 2);

        while (hospital.Count > 0)
        {
            Console.WriteLine("Следующим на прием идет тот у кого: " + hospital.Dequeue());
        }
    }
}