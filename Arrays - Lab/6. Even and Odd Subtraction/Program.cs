using System;

namespace _6._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentnumber = numbers[i];
                if (currentnumber % 2 == 0)
                {
                    sumEven += currentnumber;
                }
                else
                {
                    sumOdd += currentnumber;
                }
            }
            int different = sumEven - sumOdd;
            Console.WriteLine(different);
        }
    }
}