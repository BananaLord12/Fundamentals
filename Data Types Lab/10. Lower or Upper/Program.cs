using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (char.IsUpper(Console.ReadLine()[0])) Console.WriteLine("upper-case");
            else Console.WriteLine("lower-case");
        }
    }
}