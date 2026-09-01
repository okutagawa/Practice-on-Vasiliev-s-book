using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 5.  Напишите программу, в которой пользователю предлагается ввести название дня недели.
// По введенному названию программа определяет порядковый номер дня в неделе.
// Если пользователь вводит неправильное название дня, программа выводит сообщение о том,
// что такого дня нет. Предложите версию программы на основе вложенных условных операторов
// и на основе оператора выбора switch.

class Task5
{
    static void Main()
    {

        Console.Write("Привет! Введи название дня недели: ");
        string a = Console.ReadLine();

        switch (a)
        {
            case "Понедельник":
                Console.WriteLine(1);
                break;
            case "Вторник":
                Console.WriteLine(2);
                break;
            case "Среда":
                Console.WriteLine(3);
                break;
            case "Четверг":
                Console.WriteLine(4);
                break;
            case "Пятница":
                Console.WriteLine(5);
                break;
            case "Суббота":
                Console.WriteLine(6);
                break;
            case "Воскресенье":
                Console.WriteLine(7);
                break;
            default:
                Console.WriteLine("Такого дня недели не существует");
                break;
        }
    }
}