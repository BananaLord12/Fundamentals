using System;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> test = Console.ReadLine()
                .Split("|")
                .ToList();

            List<int> CorrectList = new List<int>();

            for (int i = test.Count-1; i >= 0; i--)
            {
                string[] tokens = test[i].Split();
                for (int j = 0; j <= tokens.Length-1; j++)
                {
                    if (tokens[j] == "")
                    {
                        continue;
                    }
                    CorrectList.Add(int.Parse(tokens[j]));
                }
            }

            Console.WriteLine(string.Join(" ",CorrectList));
        }
    }
}