using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();
            if(end.ToCharArray()[0] < start.ToCharArray()[0])
            {
                string temp = start;
                start = end;
                end = temp;
            }

            PrintRangeASCII(start.ToCharArray()[0], end.ToCharArray()[0]);
        }

        private static void PrintRangeASCII(char start, char end)
        {

            for (int i = start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

        }
    }
}