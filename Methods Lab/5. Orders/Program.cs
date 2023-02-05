using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateOrder(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void CalculateOrder(string type, int quantity)
        {
            switch (type)
            {
                case "coffee":
                    Console.WriteLine((quantity * 1.50).ToString("F2"));
                    break;
                case "water":
                    Console.WriteLine((quantity * 1.00).ToString("F2"));
                    break;
                case "coke":
                    Console.WriteLine((quantity * 1.40).ToString("F2"));
                    break;
                case "snacks":
                    Console.WriteLine((quantity * 2.00).ToString("F2"));
                    break;
            }
        }
    }
}