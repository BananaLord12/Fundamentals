using System;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] totalletters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach(char c in totalletters)
            {
                if (c == ' ') { continue; }

                if(letters.ContainsKey(c))
                {
                    letters[c]++;
                }
                else
                {
                    letters.Add(c, 1);
                }
            }

            foreach(var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}