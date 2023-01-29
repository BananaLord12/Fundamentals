using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string element in arr2)
            {
                if (arr1.Contains(element))
                {
                    Console.Write(element + " ");
                }
            }
        }
    }
}