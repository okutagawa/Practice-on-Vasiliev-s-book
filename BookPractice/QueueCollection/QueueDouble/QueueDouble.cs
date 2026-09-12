using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueDouble
    {
        static void Main()
        {
            Queue<string> queue1 = new Queue<string>();

            Queue<string> queue2 = new Queue<string>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "выход")
                {
                    break;
                }
                if (queue1.Count == queue2.Count)
                {
                    queue1.Enqueue(input);
                }
                else if (queue1.Count > queue2.Count)
                {
                    queue2.Enqueue(input);
                }
                else
                {
                    queue1.Enqueue(input);
                }

                Console.WriteLine("Пользователей в первой очереди: " + queue1.Count);
                Console.WriteLine("Пользователей во второй очереди: " + queue2.Count);

            }
        }
    }
}