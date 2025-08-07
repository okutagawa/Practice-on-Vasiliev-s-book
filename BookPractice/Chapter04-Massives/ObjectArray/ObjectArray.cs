using System;


namespace BookPractice;

class ObjectArray
{
    static void Main()
    {
        // массив из трех переменных типа Object
        Object[] objs = new Object[3];

        // элементам массива присваиваются значения разных типов

        objs[0] = 123;                  // Целое число
        objs[1] = 'A';                  // Символ
        objs[2] = "Третий элемент";     // Текст

        Console.WriteLine("Создан следующий массив: ");

        for (int i = 0; i < objs.Length; i++)
        {
            Console.WriteLine(i + ": " + objs[i]);
        }
        Console.WriteLine();
        // Новые значения элементов
        objs[0] = (int)objs[0] + 111;   // Целое число
        objs[1] = "Второй элемент";     // Текст
        objs[2] = 3.141592;             // Действительное число

        Console.WriteLine("После присваивания значений: ");
        for (int i = 0; i < objs.Length; i++)
        {
            Console.WriteLine(i + ": " + objs[i]);
        }
        Console.WriteLine();

        int[] nums = { 10, 20, 30 };
        // Переменная массива присваивается как значение элементу массива
        objs[2] = nums;

        Console.WriteLine("Целочисленный массив: ");
        // отображение элементов целочисленного массива
        for (int i = 0; i < ((int[])objs[2]).Length; i++)
        {
            Console.Write("{0,3}", ((int[])objs[2])[i]);
        }
        Console.WriteLine();

        // Новое значение элемента в числовом массиве
        ((int[])objs[2])[1] = 0;
        Console.WriteLine("Ещё раз тот же массив: ");
        // Отображение элементов целочисленного массива
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("{0,3}", nums[i]);
        }
        Console.WriteLine();
    }
}