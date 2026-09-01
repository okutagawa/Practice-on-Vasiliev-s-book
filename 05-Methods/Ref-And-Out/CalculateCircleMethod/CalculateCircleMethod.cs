using System;

namespace CalculateCircleMethod;

public class CalculateCircleMethod
{
    static void CalculateCircle(double radius, out double area, out double circumference)
    {
        circumference = 2 * Math.PI * radius;

        area = Math.PI * Math.Pow(radius, 2);
    }

    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        CalculateCircle(radius, out double area, out double circumference);

        Console.WriteLine($"Радиус круга: {radius}\nПлощадь круга: {Math.Round(area, 2)}\nДлина окружности: {Math.Round(circumference,2)}");
    }
}