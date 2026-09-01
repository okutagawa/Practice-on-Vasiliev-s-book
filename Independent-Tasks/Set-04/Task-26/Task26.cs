using System;

namespace BookPractice;

// Задание из Stepik Противоположности притягиваются.

// Дан массив из целых чисел. Определи, есть ли в нем два противоположных
// числа (таких, что их сумма равна 0). Если такие числа найдутся,
// выведи их индексы в порядке возрастания через пробел.Если таких чисел нет,
// ничего выводить не нужно.

class Task26
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        string[] numbers = a.Split(' ');
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++) // второй раз проходимся по массиву ищем второе число
            { 
                if (nums[i] + nums[j] == 0) // если число первого прохода суммировать с числом второго прохода и получится 0, то выводим
                {
                    Console.Write(i + " " + j);
                }
            }
        }
    }
}