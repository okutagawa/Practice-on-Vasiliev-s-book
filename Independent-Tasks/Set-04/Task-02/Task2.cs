using System;

namespace BookPractice;

// Задание 2. Напишите программу, в которой создается массив из 11 целочисленных элементов.
// Массив заполняется степенями двойки до 1024. При заполнении массива учесть, что начальный элемент равен 1,
// а каждый следующий больше предыдущего в 2 раза.Отобразить массив в консольном окне в прямом
// и обратном порядке.Размер массива задается переменной.

class Task2
{
    static void Main()
    {
        int a = 11;
        int[] nums = new int[a];

        Console.WriteLine("Массив степеней двойки: ");

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = (int)Math.Pow(2, i);
            Console.Write("| " + nums[i] + " ");
        }
        Console.WriteLine("|\n");

        Console.WriteLine("Массив степеней двойки в обратном порядке: ");
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            Console.Write("| " + nums[i] + " ");
        }
        Console.WriteLine("|");
    }
}