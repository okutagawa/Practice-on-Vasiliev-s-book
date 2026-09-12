using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueCircule
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            for (int i = 1; i <= 5; i++)
            {
                numbers.Enqueue(i);
            }

            Console.WriteLine($"Старт: Count = {numbers.Count}; Элементы: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                int n = numbers.Dequeue();
                n++;
                numbers.Enqueue(n);
                Console.WriteLine($"Шаг {i + 1}: Count = {numbers.Count}; Элементы: ");
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}