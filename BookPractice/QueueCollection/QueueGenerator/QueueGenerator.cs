using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueGenerator
    {
        static void Main()
        {
            Queue<int> tasks = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                tasks.Enqueue(i);
            }

            // int res;
            while (tasks.Count > 0)
            {
                int task = tasks.Dequeue();
                task--;

                if (task > 0)
                {
                    tasks.Enqueue(task);
                }


                Console.WriteLine("Осталось задач: " + tasks.Count);
            }
        }
    }
}