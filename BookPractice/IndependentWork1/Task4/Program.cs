using System;

// Напишите программу, в которой пользователю предлагается ввести
// название месяца и количество дней в этом месяце. Программа выводит
// сообщение о том, что соответствующий месяц содержит указанное количество дней

class Task4
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте, введите название месяца и кол-во дней в этом месяце!");

        Console.Write("Укажите месяц: ");
        string mounth = Console.ReadLine();

        Console.Write("Укажите кол-во дней в месяце: ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine($"Месяц {mounth} содержит в себе {day} дней!");

    }
}