using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Количество элементов, больших предыдущего.

// Дан массив целых чисел. Напиши программу, которая посчитает, сколько элементов массива строго больше своего предыдущего элемента.

class Task13
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        int[] nums = new int[n];

        string[] numbers = a.Split(' ');

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        int count = 0; // объявляем счетчик для подсчета кол-ва элементов массива подходящих по условию
        for (int i = 0; i < nums.Length - 1; i++) // обозначаем верхнюю границу как nums.Length - 1, т.к. обращение i+1 в условном операторе даст последний элемент безопасно и без выхода за границу
        {
            if (nums[i + 1] > nums[i]) // проверяем условие задачи 
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}