using System;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string numbers = "";
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                numbers += i + " ";
                sum += i;
            }
            Console.WriteLine(numbers);
            Console.WriteLine($"Sum: {sum}");
        }
    }
}