using System;

namespace _5._Pring_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (start = start; start <= end; start++)
            {
                Console.Write(" " + Convert.ToChar(start));
            }
        }
    }
}