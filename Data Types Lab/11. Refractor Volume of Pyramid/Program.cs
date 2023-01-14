using System;

namespace _11._Refractor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double L = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double W = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double H = double.Parse(Console.ReadLine());

            double V = (L * W * H) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}