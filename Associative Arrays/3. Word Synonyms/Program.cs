using System;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            string word = "";
            string synonyms = "";


            for (int i = 0; i < n * 2; i++)
            {
                if(i % 2 == 0)
                {
                    word = Console.ReadLine();
                }
                else
                {
                    synonyms = Console.ReadLine();
                    words[word].Add(synonyms);
                    continue;
                }

                if (words.ContainsKey(word) == false)
                {
                    words.Add(word, new List<string>());
                    continue;
                }            
            }

            foreach(var Word in words)
            {
                Console.WriteLine($"{Word.Key} - " + string.Join(", ", Word.Value));
            }
        }
    }
}