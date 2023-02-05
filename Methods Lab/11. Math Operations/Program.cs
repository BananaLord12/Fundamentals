using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num1, operation, num2);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b * 1.0;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            return result;
        }
    }
}