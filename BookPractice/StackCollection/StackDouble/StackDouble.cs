using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BookPractice
{
    public class StackDouble
    {
        static void Main()
        {
            Queue<int> qPush = new Queue<int>();

            Queue<int> qPop = new Queue<int>();


            Random rnd = new Random();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Push")
                {
                    int value = rnd.Next(1,100);
                    qPush.Enqueue(value);
                    Console.WriteLine("В стек было добавлено значение: " + value);
                    PrintStack(qPush, qPop);
                }
                else if (input == "Pop")
                {
                    while (qPush.Count > 1)
                    {
                        qPop.Enqueue(qPush.Dequeue());
                    }

                    int peek = qPush.Dequeue();
                    Console.WriteLine("Из стека извлечено: " + peek);

                    while (qPop.Count > 0)
                    {
                        qPush.Enqueue(qPop.Dequeue());
                    }
                    PrintStack(qPush, qPop);
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка.");
                }
            }
        }

        static void PrintStack(Queue<int> qPush, Queue<int> qPop)
        {
            // 1. Перекладываем всё из qPush в qPop, чтобы получить порядок "сверху вниз"
            while (qPush.Count > 0)
            {
                qPop.Enqueue(qPush.Dequeue());
            }

            // 2. Выводим элементы (первый в qPop — это верх стека)
            Console.Write("Текущий стек (сверху вниз): ");
            foreach (int item in qPop)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 3. Возвращаем всё обратно в qPush (чтобы не сломать основную логику)
            while (qPop.Count > 0)
            {
                qPush.Enqueue(qPop.Dequeue());
            }
        }
    }
}