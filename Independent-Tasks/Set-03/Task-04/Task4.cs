using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 4. Напишите программу, в которой пользователь вводит целое числов диапазоне от 1 до 7,
// а программа определяет по этому числу день недели.Если введенное пользователем число выходит
// за допустимый диапазон, выводится сообщение о том, что введено некорректное значение.
// Используйте оператор выбора switch. Предложите механизм обработки ошибки,
// связанной с вводом нечислового значения.

class Task4
{
    static void Main()
    {

        Console.Write("Привет! Введи число от 1 до 7: ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 1 && a <= 7)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }   
        }
        else
        {
            Console.WriteLine("Число выходит за грани нужных, или вовсе не является числом");
        }
    }
}