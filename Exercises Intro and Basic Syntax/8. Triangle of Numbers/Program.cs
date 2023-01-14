using System;

namespace _8._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;
            string final = "";

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    final += rows + " ";
                }
                Console.WriteLine(final);
                final = "";
            }
        }
    }
}