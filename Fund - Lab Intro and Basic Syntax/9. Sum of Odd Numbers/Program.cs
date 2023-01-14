using System;

namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 0;
            int counter = 0;
            while (counter < n)
            {
                i++;
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                total += i;
                counter++;
            }

            Console.WriteLine($"Sum: {total}");
        }
    }
}