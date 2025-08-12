using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Поменять местами первый минимум и последний максимум.

// Дан массив целых чисел. Напиши программу, которая меняет местами первый минимальный
// элемент и последний максимальный элемент массива. Индексация начинается с нуля.

class Task18
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

        int min = nums[0]; // объявляем две переменные для минимума
        int index1 = 0;
        
        int max = nums[0]; // также делаем для максимума
        int index2 = 0;
        for (int i = 1; i < nums.Length; i++) // выполняем поиск минимума и максимума со второго индекса
        {
            if (nums[i] < min)
            {
                min = nums[i];
                index1 = i;
            }
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];               
                index2 = i;
            }
            if (nums[i] == max) // используем оператор ==, т.к. при равенстве мы перезаписываем индекс на более позднее вхождение того же максимума
            {
                index2 = i; // обновляем только индекс, т.к. само максимальное число уже было найдено
            }
        }

        nums[index2] = min; // элементу с индексом максимума присваиваем значение минимума
        nums[index1] = max; // элементу с индексом минимума присваиваем значение максимума
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        // Console.WriteLine($"Минимум - {min} и индекс минимума {index1}\nМаксимум - {max} и индекс максимума {index2}");
    }
}