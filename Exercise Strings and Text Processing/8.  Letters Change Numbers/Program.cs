using System;

namespace _8.__Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray(); 

            double total = 0;

            foreach (string calc in text)
            {
                total += Calculations(calc);
            }

            Console.WriteLine(String.Format("{0:0.00}",Math.Round(total,2,MidpointRounding.AwayFromZero)));
        }

        static double Calculations(string input)
        {
            double total = 0;
            char[] token = input.ToCharArray();
            string digit = "";

            for (int i = 1; i < input.Length-1; i++)
            {
                digit += input[i];
            }

            if (char.IsUpper(token[0]))
            {
                double a = double.Parse(digit); //number
                int index = AlphabetIndex(token[0]); //alphabet pos
                total = a / index;
            }
            else
            {
                int a = int.Parse(digit); //number
                int index = AlphabetIndex(token[0]); //alphabet pos
                total = a * index;
            }

            if (char.IsLower(token[input.Length-1]))
            {
                int index = AlphabetIndex(token[input.Length - 1]); //alphabet pos
                total += index;
            }
            else
            {
                int index = AlphabetIndex(token[input.Length - 1]); //alphabet pos
                total -= index;
            }

            return total;
        }

        static int AlphabetIndex(char c)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet.IndexOf(char.ToUpper(c))+1;
        }
    }
}