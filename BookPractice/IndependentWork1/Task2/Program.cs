using System;

// Напишите программу, в которой пользователь вводит имя и возраст.
// Программа отображает сообщение об имени и возрасте пользователя.
// Предложите консольную версию программы

class Task2
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте, укажите пожалуйста Ваше имя и возраст");
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Ваше имя: {name}");
        Console.WriteLine($"Ваш возраст: {age}");
    }
}