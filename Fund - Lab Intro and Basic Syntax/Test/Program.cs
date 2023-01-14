using System;
using System.Reflection.Metadata.Ecma335;

namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if(number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    number = int.Parse(Console.ReadLine());
                    continue;
                }
                break;
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}