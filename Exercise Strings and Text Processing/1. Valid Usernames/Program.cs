using System;

namespace _1._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(", ")
                .ToArray();
            bool isValid = true;

            foreach(string word in words)
            {
                isValid = true;
                if(word.Length <= 3 || word.Length >= 16)
                {
                    continue;
                }
                char[] test = word.ToCharArray();
                foreach(char c in test)
                {
                    if(char.IsDigit(c) || char.IsLetter(c) || c == '-' || c == '_')
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if(isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}