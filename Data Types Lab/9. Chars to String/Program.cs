using System;

namespace _9._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string final = "";
            for (int i = 0; i <= 2; i++)
            {
                string symbol = Console.ReadLine();
                final += symbol;
            }
            Console.WriteLine(final);
        }
    }
}