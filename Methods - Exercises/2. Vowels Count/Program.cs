using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = CountVowels(input);
            Console.WriteLine(result);
        }

        public static int CountVowels(string input)
        {
            int total = 0;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] test = input.ToCharArray();

            foreach(char c in test)
            {
                if (vowels.Contains(char.ToLower(c)))
                {
                    total++;
                }
            }

            return total;
        }
    }
}