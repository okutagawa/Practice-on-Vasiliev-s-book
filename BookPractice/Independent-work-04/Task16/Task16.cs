using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Сдвиг по кругу.

// Дан массив целых чисел. Напиши программу, которая выполняет циклический сдвиг
// элементов массива на один шаг вправо. Например, если элементы массива
// нумеруются начиная с нуля, то 0‑й элемент станет 1‑м, 1‑й станет 2‑м, …
// а последний элемент переместится на позицию 0.
// Пример: [3 5 7 9] → [9 3 5 7].

class Task16
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        int[] nums = new int[n];

        string[] numbers = a.Split(' ');

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        int x = nums[nums.Length - 1]; // присваиваем последнее число новой переменной для её сохранения, в нашем случае это 9

        for (int i = nums.Length - 2; i >= 0; i--) // проходимся по массиву слева направо от предпоследнего числа
        {
            // используем стандартную перестановку числа
            int s = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = s; 
        }
        x = nums[0]; // после прохождения цикла присваиваем первому индексу наше последнее число и получается, что оно встает вначало

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}