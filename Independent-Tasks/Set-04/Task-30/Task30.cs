using System;
using System.Security.AccessControl;

namespace BookPractice;

// Задание из Stepik Строитель Андрей.

// Напиши программу, которая поможет Андрею посчитать,
// сколько рабочих дней ему потребуется, чтобы построить все дома.


//Формат входных данных:
//На первой строке — одно целое число n(1≤n≤100) — количество домов.

//На второй строке — n целых чисел

//Формат выходных данных:
//Одно целое число — минимальное количество рабочих дней, которое потребуется Андрею.



class Task30
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string[] a = Console.ReadLine().Split(' ');
        int[] nums = new int[n]; 

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(a[i]);
        }

        int resultDays = 0;
        for (int i = 0; i < n; i++)
        {
            resultDays += nums[i];
        }

        int result = (resultDays + 11) / 12; // трюк для округления вверх при целочисленном делении
        Console.WriteLine(result);
    }
}