using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string word = Console.ReadLine();

            while(word.IndexOf(key) != -1)
            {
                int index = word.IndexOf(key);
                word = word.Remove(index, key.Length);
            }
            Console.WriteLine(word);
        }
    }
}