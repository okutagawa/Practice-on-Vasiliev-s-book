using System;

namespace BookPractice;

class TryCatch
{
    static void Main()
    {
        try
        {
            Console.Write("Введите действительное число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Поздравляем! Вы ввели число {a}!");
        }
        catch
        {
            Console.WriteLine("Необходимо было ввести число!!!");
        }
    }
}