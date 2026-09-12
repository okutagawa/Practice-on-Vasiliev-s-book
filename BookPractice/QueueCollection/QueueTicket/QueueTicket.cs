using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueTicket
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            string task = "Задача";
            AddTicket(queue, task);
            ProcessNext(queue);

        }
        static void AddTicket(Queue<string> queue, string task)
        {
            queue.Enqueue(task);
        }

        static void ProcessNext(Queue<string> queue)
        {
            string task = queue.Dequeue();
            Console.WriteLine("Выполняется: " + task);           
        }
    }
}