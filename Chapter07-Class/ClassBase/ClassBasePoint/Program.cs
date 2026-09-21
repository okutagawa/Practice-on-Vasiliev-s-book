using System;
using System.Net.NetworkInformation;

namespace ClassBaseExample
{
    class Program
    {
        static void Main()
        {
            Point p = new Point();

            p.x = 4;
            p.y = 2;
            p.color = Color.Green;
            Console.WriteLine($"X: {p.x} \t Y: {p.y} \t Color: {p.color}");

            Point p2 = new Point();

            p2.x = 2;
            p2.y = 6;
            p2.color = Color.Blue;
            Console.WriteLine($"X: {p2.x} \t Y: {p2.y} \t Color: {p2.color}");

            Point p3 = p2;

            p3.x = 4;
            p3.y = 4;
            p3.color = Color.Black;
            Console.WriteLine($"X: {p3.x} \t Y: {p3.y} \t Color: {p3.color}");

            Point p4 = p3;
            p4 = new Point();
            Console.WriteLine($"X: {p4.x} \t Y: {p4.y} \t Color: {p4.color}");

        }
    }
}