using System;

// Напишите программу, в которой пользователь водит имя и год рождения, а программа отображает сообщение, содержащее имя пользователя
// и его возраст

class Task6
{
    static void Main()
    {
        string name;
        int age;

        Console.WriteLine("Добро пожаловть! Пожалуйста напиши как тебя зовут и сколько тебе лет");

        Console.Write("Мое имя: ");
        name = Console.ReadLine();
        Console.Write("Мой возраст: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Приятно познакомиться {name}! Теперь мы будем знать, что тебе {age} годиков)");

    }
}