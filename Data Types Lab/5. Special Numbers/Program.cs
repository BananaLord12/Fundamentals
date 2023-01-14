using System;

namespace _5._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          int n = int.Parse(Console.ReadLine());
                        int[] validNums = new int[] {5,7,11};
                        bool isvalid = false;
                        for (int i = 1; i <= n; i++)
                        {
                            isvalid = false;
                            int sum = (i % 10) + i / 10;
                            if (validNums.Contains(sum)) isvalid = true;
                            Console.WriteLine($"{i} -> {isvalid}");
                        }*/
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            bool isSpecialNumer = false;
            for (int i = 1; i <= n; i++)
            {
                int num = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isSpecialNumer = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecialNumer);
                total = 0;
                i = num;
            }

        }
    }
}