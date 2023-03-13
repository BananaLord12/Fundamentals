using System;

namespace _5._Multiply_BIg_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string longDigit = Console.ReadLine();
            longDigit = longDigit.TrimStart(new char[] { '0' });
            char[] bigNum = longDigit.ToCharArray();
            int num = int.Parse(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine("0");
                return;
            }

            List<string> Product = new List<string>();

            int calc = 0;
            for (int i = bigNum.Length-1; i >= 0; i--)
            {
                calc = (int.Parse(Convert.ToString(bigNum[i])) * num) + calc;
                Product.Insert(0, (calc % 10).ToString());
                calc /= 10;

            }

            if(calc > 0)
            {
                Console.WriteLine($"{calc}{string.Join("",Product)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("",Product)}");
            }
        }
    }
}