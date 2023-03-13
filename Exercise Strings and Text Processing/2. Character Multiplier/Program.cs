using System;

namespace _2._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string a = strings[0];
            string b = strings[1];

            char[] achars = a.ToCharArray();
            char[] bchars = b.ToCharArray();

            int totalsum = 0;

            if(achars.Length > bchars.Length)
            {
                for (int i = 0; i < bchars.Length; i++)
                {
                    totalsum += achars[i] * bchars[i];
                }

                for (int i = bchars.Length; i < achars.Length; i++)
                {
                    totalsum += achars[i];
                }
            }
            else if (achars.Length < bchars.Length)
            {
                for (int i = 0; i < achars.Length; i++)
                {
                    totalsum += achars[i] * bchars[i];
                }
                for (int i = achars.Length; i < bchars.Length; i++)
                {
                    totalsum += bchars[i];
                }
            }
            else
            {
                for (int i = 0; i < achars.Length; i++)
                {
                    totalsum += achars[i] * bchars[i];
                }
            }
            Console.WriteLine(totalsum);
        }
    }
}