using System;

namespace _1._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = SmallestNumberFromArray(numbers);
            Console.WriteLine(result);
        }

        private static int SmallestNumberFromArray(int[] numbers)
        {
            int firstResult = Math.Min(numbers[0], numbers[1]);
            return Math.Min(firstResult, numbers[2]);
        }
    }
}