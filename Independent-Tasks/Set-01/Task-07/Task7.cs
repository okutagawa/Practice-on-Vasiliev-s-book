using System;

// Напишите программу, в которой по возрасту определяется год рождения.

class Task7
{
    static void Main()
    {
        int age;

        Console.WriteLine("Привет! Сейчас я попробую угадать в каком году ты родился, укажи свой возраст.");

        Console.Write("Мой возраст: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Я думаю, что ты родился в {2025-age} году при том, что у тебя уже было день рождение.");
        Console.WriteLine($"Если дня рождения не было, то ты родился в {2024 - age} году.");

    }
}