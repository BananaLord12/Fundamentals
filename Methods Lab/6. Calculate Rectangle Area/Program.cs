using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateRectangle(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine())));
        }

        static double CalculateRectangle(double width, double height)
        {
            return width * height;
        }
    }
}