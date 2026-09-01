using System;

// Напишите программу, в которой пользователь последовательно вводит название текущего дня недели, название месяца и дату (номер дня
// в месяце). Программа выводит сообщение о сегодняшней дате (день
// недели, дата, месяц). Используйте консольный ввод и вывод данных. 

class Task3
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте, укажите текущее время!");

        Console.Write("Укажите день недели: ");
        string dayned = Console.ReadLine();

        Console.Write("Укажите название месяца: ");
        string mounth = Console.ReadLine();

        Console.Write("Укажите число: ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine($"Введенная дата следующая: день недели - {dayned}; месяц - {mounth}; число - {day}");
    }
}