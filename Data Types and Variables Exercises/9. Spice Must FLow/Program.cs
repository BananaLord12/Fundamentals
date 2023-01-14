using System;

namespace _9._Spice_Must_FLow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalyield = int.Parse(Console.ReadLine());
            int totalextracted = 0;
            int daysCount = 0;

            if(totalyield < 100)
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalextracted);
            }
            else
            {
                while (totalyield >= 100)
                {
                    totalextracted += totalyield - 26;
                    totalyield -= 10;
                    daysCount++;
                }
                totalextracted -= 26;
                Console.WriteLine(daysCount);
                Console.WriteLine(totalextracted);
            }
        }
    }
}