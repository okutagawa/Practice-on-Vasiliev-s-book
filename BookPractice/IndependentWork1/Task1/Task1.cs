using System;

// Напишите программу, в которой пользователь вводит сначала имя,
// а затем фамилию. Программа выводит сообщение с информацией
// об имени и фамилии пользователя. 
class Task1
{
    static void Main()
    {
        string name = Console.ReadLine();
        string secondname = Console.ReadLine();
        Console.WriteLine("Добро пожаловать!");
        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine($"Ваша фамилия: {secondname}");
    }
}