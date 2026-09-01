using System;

namespace BookPractice;

class MaxElement
{
    static void Main()
    {
        // Переменные для записи значения элемента и индекса

        int value, index;

        // Размер массива
        int size = 15;

        // Создание объекта рандом и массива
        Random random = new Random();

        int[] nums = new int[size];

        // Отображение массива
        for (int i = 0; i < size; i++)
        {
            nums[i] = random.Next(1, 101);

            Console.Write(nums[i] + " ");
        }

        Console.WriteLine();

        // Поиск наибольшего элемента
        index = 0; // начальное значение для индекса

        value = nums[index]; // значение элемента с индексом

        for (int i = 1; i < nums.Length; i++)
        {
            // Если значение проверяемого элемента больше текущего наибольшего значения
            if (nums[i] > value)
            {
                value = nums[i]; //  новое наибольшее значение 
                index = i; // новое значение для индекса 
            }
        }
        // Отображение результата
        Console.WriteLine("Наибольшее значение: " + value);
        Console.WriteLine("Индекс элемента: " + index);
    }
}