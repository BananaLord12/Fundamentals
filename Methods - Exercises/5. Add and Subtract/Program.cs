using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = AddFirstTwo(num1, num2);
            Console.WriteLine(SubtractFromFirstTwo(result,num3));
        }

        private static int AddFirstTwo(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int SubtractFromFirstTwo(int sum, int num3)
        {
            return sum - num3;
        }
    }
}