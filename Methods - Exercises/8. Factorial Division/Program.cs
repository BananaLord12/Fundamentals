namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = FactorialDivision(num1, num2);
            Console.WriteLine(result.ToString("F2"));
        }

        private static double FactorialDivision(int num1, int num2)
        {
            double result1 = 1;
            double result2 = 1;

            for (int i = num1; i > 0; i--)
            {
                result1 *= i;
            }

            for (int i = num2; i > 0; i--)
            {
                result2 *= i;
            }


            return result1 / result2;
        }
    }
}