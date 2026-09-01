using System;

namespace ParseCoordinatesMethod;

public class ParseCoordinatesMethod
{
    static void Main()
    {
        string point = Console.ReadLine();

        ParseCoordinates(point, out int x, out int y);

        Console.WriteLine($"Заданные координаты:\nX = {x}\nY = {y}");
    }

    static void ParseCoordinates(string point, out int x, out int y)
    {
        string[] finalPoint = point.Split(',');

        int[] convertPoint = new int[2];
        for (int i = 0; i <= convertPoint.Length - 1; i++)
        {
            convertPoint[i] = Convert.ToInt32(finalPoint[i]);
        }

        x = convertPoint[0];
        y = convertPoint[1];
    }
}