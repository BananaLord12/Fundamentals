using System;

namespace _6._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> chars = Console.ReadLine().ToCharArray().ToList();

            int currentpos = 0;
            char currentChar = ' ';
            int count = 0;

            currentChar = chars[0];

            for (int i = 0; i < chars.Count;)
            {
                if (i + 1 == chars.Count) break;
                if(currentChar == chars[i + 1])
                {
                    i++;
                    count++;
                    continue;
                }
                else
                {
                    if (currentChar == chars[i + 1]) continue;
                    chars.RemoveRange(currentpos+1, count);
                    currentpos++;
                    i = currentpos;
                    currentChar = chars[i];
                    count = 0;
                    continue;
                }
            }

            if(count >= 1)
            {
                chars.RemoveRange(currentpos, count);
            }

            Console.WriteLine(string.Join("",chars));
        }
    }
}