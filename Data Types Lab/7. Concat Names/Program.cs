using System;

namespace _7._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name1 = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(String.Concat(name, delimiter, name1));
        }
    }
}