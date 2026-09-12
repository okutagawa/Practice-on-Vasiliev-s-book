using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueExample
    {
        static void Main()
        {
            // Это структура данных по принципу FIFO (First In, First Out — «Первый пришел, первый вышел»).
            // Аналогия из жизни:
            // Ты приходишь в поликлинику, берешь талончик и садишься в коридоре.
            // Врач вызывает первого, кто пришел.Пока он его осматривает,
            // в конце очереди занимают место новые люди.
            // Ты не можешь пройти без очереди, и выйти из середины тоже нельзя.

            Queue<string> printer = new Queue<string>();

            printer.Enqueue("Документ 1"); // добавление элемента в конец очереди

            // printer.Dequeue(); // берет первый элемент и удаляет его из очереди

            // printer.Peek(); // смотрит на первый элемент, но не забирает его

            // printer.Count(); // сколько элементов сейчас в очереди

            printer.Enqueue("Документ 2");
            printer.Enqueue("Документ 3");
            printer.Enqueue("Документ 4");

            Console.WriteLine("Сейчас будет печататься: " + printer.Peek());

            // пока в очереди есть элементы (Count > 0), забираем первый
            while (printer.Count > 0)
            {
                string currentTask = printer.Dequeue();
                Console.WriteLine("Печатаю: " + currentTask);
            }
        }
    }
}