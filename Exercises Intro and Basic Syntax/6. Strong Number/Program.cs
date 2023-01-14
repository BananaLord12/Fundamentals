using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sum = 0;

            foreach(char c in num)
            {
                int temp = 1;
                for (int i = 1; i <= int.Parse(c.ToString()); i++)
                {
                    temp = temp * i;
                }
                sum += temp;
            }
            if(sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("no"); }
        }
    }
}