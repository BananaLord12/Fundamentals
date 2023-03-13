using System;

namespace _4._Ceaser_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            string output = "";

            foreach(char c in input)
            {
                output += (char)(c + 3);
            }
            Console.WriteLine(output);
        }
    }
}