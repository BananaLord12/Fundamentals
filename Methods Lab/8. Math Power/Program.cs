using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = RaiseTheNumber(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }

        private static double RaiseTheNumber(double number,int power)
        {
            return Math.Pow(number, power);
        }
    }
}