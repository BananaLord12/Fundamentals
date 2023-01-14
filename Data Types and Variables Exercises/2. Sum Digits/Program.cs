using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < num.Length; i++)
            {
                total += int.Parse(num[i].ToString());
            }
            Console.WriteLine(total);
        }
    }
}