using System;

namespace _10._Multiple_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int[] number = GetIntArray(num);

            int evensum = GetSumofEvenDigits(number);
            int oddsum = GetSumOfOddDigits(number);

            Console.WriteLine(GetMultipleOfEvenAndOdds(evensum,oddsum));
        }

        private static int GetSumofEvenDigits(int[] num)
        {
            int tempsum = 0;
            for (int i = 1; i <= num.Length; i++)
            {
                if (num[i-1] % 2 == 0)
                {
                    tempsum += num[i-1];
                }
            }
            return tempsum;
        }

        private static int GetSumOfOddDigits(int[] num)
        {
            int tempsum = 0;
            for (int i = 1; i <= num.Length; i++)
            {
                if (num[i - 1] % 2 != 0)
                {
                    tempsum += num[i - 1];
                }
            }
            return tempsum;
        }

        private static int GetMultipleOfEvenAndOdds(int evensum, int oddsum)
        {
            return evensum * oddsum;
        }

        private static int[] GetIntArray(int num)
        {
            List<int> listofints = new List<int>();
            while(num > 0)
            {
                listofints.Add(num % 10);
                num = num / 10;
            }
            listofints.Reverse();
            return listofints.ToArray();
        }
    }
}