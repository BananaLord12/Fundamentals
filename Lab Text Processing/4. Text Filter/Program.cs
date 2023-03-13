using System;

namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)       
        {
            string[] bannedWord = Console.ReadLine()
                .Split(", ");
            string text = Console.ReadLine();

            foreach (string banword in bannedWord)
            {
                if (text.Contains(banword))
                {
                    text = text.Replace(banword, new string('*', banword.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}