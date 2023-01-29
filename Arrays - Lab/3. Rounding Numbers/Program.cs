using System;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
               string s = Console.ReadLine();
               string[] strings = s.Split(" ");

                for (int i = 0; i <= strings.Length-1; i++)
                {
                    Console.WriteLine($"{strings[i]} => {(int)Math.Round(double.Parse(strings[i]),MidpointRounding.AwayFromZero)}");
                }
        }
    }
}