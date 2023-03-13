using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string explosionString = Console.ReadLine();


            int strength = 0;

            for (int i = 0; i < explosionString.Length;i++)
            {
                if (explosionString[i] == '>') //explosion
                {
                    strength += int.Parse(explosionString[i + 1].ToString());
                }

                if (strength > 0 && explosionString[i] != '>') //explosion removes stuff
                {

                    explosionString = explosionString.Remove(i, 1);
                    strength--;
                    i--;
                }
            }

            Console.WriteLine(string.Join("",explosionString));
        }
    }
}