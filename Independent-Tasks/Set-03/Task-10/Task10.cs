using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 10. Напишите программу, в которой вычисляется сумма чисел,
// удовлетворяющих таким критериям: при делении числа на 5 в остатке получается 2,
// или при делении на 3 в остатке получается 1. Количество чисел в сумме вводится пользователем.
// Программа отображает числа, которые суммируются, и значение суммы.
// Используйте обработку исключений.

class Task10
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int s = 0;
        int cur_num = 1;
        while (count < n)
        {
            if (cur_num % 5 == 2 || cur_num % 3 == 1)
            {
                Console.WriteLine("Добавляем число: {0}", cur_num);
                s += cur_num;
                count++;
            }
            cur_num++;
        }
        Console.WriteLine("Итоговая сумма: {0}", s);
    }
}