using System;

namespace BookPractice;

// Задание из Stepik Цветник.

// Григорий ведёт цветочный бизнес. Его парник разделён на 15 участков,
// расположенных в виде таблицы 3 (строки) × 5 (столбцы). На каждом участке выращиваются
// только один вид роз: красные, белые или розовые.За год на каждом участке
// вырастает ровно 100 цветов. Требуется определить годовую выручку Григория,
// полученную от продажи цветов, если известен вид роз на каждом участке и цены на розы.

// Формат входных данных:
//Первые 3 строки: по 5 символов, разделённых пробелом:

//к — красные розы;
//б — белые розы;
//р — розовые розы.

//Четвёртая строка содержит три целых числа, разделенные пробелом:

//цена красной розы;
//цена белой розы;
//цена розовой розы.
//Формат выходных данных:
//Одно число — годовая выручка Григория.

class Task28
{
    public static void Main()
    {
        int row = 3;
        int cols = 5;

        char[,] symbs = new char[row, cols];

        for (int i = 0; i < row; i++)
        {
            string b = Console.ReadLine();
            string[] numbers = b.Split(' ');

            for (int j = 0; j < cols; j++)
            {
                symbs[i, j] = char.Parse(numbers[j]);
            }
        }

        string a = Console.ReadLine(); // вводим строку с массивом цен на розы
        string[] txtPrice = a.Split(' '); 

        int redRosePrice = int.Parse(txtPrice[0]); // цена для красных роз
        int whiteRosePrice = int.Parse(txtPrice[1]); // цена для белых роз
        int pinkRosePrice = int.Parse(txtPrice[2]); // цена для розовых 

        int sumRed = 0, sumWhite = 0, sumPink = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (symbs[i, j] == 'к')
                {
                    sumRed++;
                }
                else if (symbs[i,j] == 'б')
                {
                    sumWhite++;
                }
                else if (symbs[i,j] == 'р')
                {
                    sumPink++;
                }
            }
        }

        int summaryPrice = (sumRed * redRosePrice * 100) + (sumWhite * whiteRosePrice * 100)
            + (sumPink * pinkRosePrice * 100); // расчитываем по сумме произведений 

        Console.WriteLine(summaryPrice);
    }
}