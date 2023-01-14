using System;

namespace _6._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[3];
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                inputs[i] = Console.ReadLine();
            }
            for (int i = 2; i >= 0; i--)
            {
                output += inputs[i] + " ";
            }
            Console.WriteLine(output);
        }
    }
}