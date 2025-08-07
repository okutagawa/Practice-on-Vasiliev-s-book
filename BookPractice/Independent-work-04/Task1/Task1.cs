using System;

namespace BookPractice;

// Задание 1. Напишите программу, в которой создается одномерный числовой массив
// и заполняется числами, которые при делении на 5 дают в остатке 2
// (числа 2, 7, 12, 17 и так далее). Размер массива вводится пользователем.
// Предусмотреть обработку ошибки, связанной с вводом некорректного значения.

class Task1
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * 5 + 2;

                Console.Write("| " + nums[i] + " ");
            }
            Console.WriteLine("|");
        }
        else if (n <= 0)
        {
            Console.WriteLine("Ведите коректное число. Размер массива должен быть положительным числом!");
        }
    }
}