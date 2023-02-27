using System;

namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int pos2 = rnd.Next(input.Length);
                string temp = input[i];
                input[i] = input[pos2];
                input[pos2] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}