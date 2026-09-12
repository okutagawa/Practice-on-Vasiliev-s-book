using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueBase
    {
        static void Main()
        {
            Queue<string> hospitalQueue = new Queue<string>();

            hospitalQueue.Enqueue("Пациент 1");
            hospitalQueue.Enqueue("Пациент 2");
            hospitalQueue.Enqueue("Пациент 3");

            while (hospitalQueue.Count > 0)
            {
                string pacient = hospitalQueue.Dequeue();
                Console.WriteLine("Следующим в кабинет заходит: " + pacient);
            }
        }
    }
}