using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());
            if(multi > 10)
            {
                Console.WriteLine($"{n} X {multi} = {n * multi}");
                return;
            }
            for (multi = multi; multi <= 10; multi++)
            {
                Console.WriteLine($"{n} X {multi} = {n* multi}");
            }
        }
    }
}