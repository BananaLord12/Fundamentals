using System;

namespace _4._Sum_of_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                char c = Console.ReadLine()[0];
                total += (char)c;
            }
            Console.WriteLine($"The sum equals: {total}");
        }
    }
}