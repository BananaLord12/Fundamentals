using System;

namespace _1._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Math.Round(double.Parse(Console.ReadLine())/1000,2):F2}");
        }
    }
}