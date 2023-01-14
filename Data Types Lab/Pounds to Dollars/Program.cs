using System;

namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(double.Parse(Console.ReadLine()) * 1.31):F3}");
        }
    }
}