using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalcap = 255;
            int currentcap = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(totalcap - num < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                totalcap -= num;
                currentcap += num;
            }
            Console.WriteLine(currentcap);
        }
    }
}