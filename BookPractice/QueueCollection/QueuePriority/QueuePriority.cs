using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueuePriority
    {
        static void Main()
        {
            Queue<string> clients = new Queue<string>();

            clients.Enqueue("Клиент 1");
            clients.Enqueue("АКлиент 2");
            clients.Enqueue("Клиент 3");
            clients.Enqueue("АКлиент 4");

            while (clients.Count > 0)
            {
                string client = clients.Dequeue();

                if (client[0] == 'А')
                {
                    clients.Enqueue(client);
                    continue;
                }
                else
                {
                    Console.WriteLine(client);
                }
            }
        }
    }
}