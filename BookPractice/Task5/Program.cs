using System;

// Напишите программу, в которой по году рождения определяется возраст пользователя. Используйте консольный ввод и вывод данных.

class Task5
{
    static void Main()
    {
        Console.Write("Здравствуйте, укажите ваш год рождения: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Предполагаю, Вам около {2025 - age} годиков");

    }
}