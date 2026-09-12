using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueNondouble
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            while (true)
            {
                int input = int.Parse(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine("Уже в очереди");
                }
                else
                {
                    numbers.Enqueue(input);
                    Console.WriteLine("В очередь попало число: " + input);
                }
            }
        }
    }
}