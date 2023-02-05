using System;

namespace _6._MIddle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = ReturnMiddleCharacters(input);
            Console.WriteLine(result);
        }

        private static string ReturnMiddleCharacters(string input)
        {
            if(input.Length == 1)
            {
                return input;
            }
            int average = input.Length / 2;
            if (input.Length % 2 == 0)
            {
                return input[average-1] + "" + input[average];
            }
            return input[average].ToString();
        }
    }
}