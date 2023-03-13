using System;

namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();

            string letter = "";
            string digits = "";
            string others = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetterOrDigit(letters[i]))
                {
                    if (char.IsDigit(letters[i]))
                    {
                        digits += letters[i];
                    }
                    else
                    {
                        letter += letters[i];
                    }
                }
                else
                {
                    others += letters[i];
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letter);
            Console.WriteLine(others);
        }
    }
}