using System;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] strings = s.Split(" ");

            for (int i = strings.Length-1; i >= 0; i--)
            {
                Console.Write(strings[i] + " ");
            }
        }
    }
}