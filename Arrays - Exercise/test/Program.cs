using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}