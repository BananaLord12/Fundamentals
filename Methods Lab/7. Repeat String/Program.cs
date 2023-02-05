using System;

namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = RepeatSequence(Console.ReadLine(),int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }

        private static string RepeatSequence(string sequence,int count)
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += sequence;
            }

            return result;
        }
    }
}