using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i < lostgames; i++)
            {
                if(i % 12 == 0)
                {
                    totalPrice += headsetPrice + mousePrice + keyboardPrice + displayPrice;
                }
                else if(i % 6 == 0)
                {
                    totalPrice += headsetPrice + mousePrice + keyboardPrice;
                }
                else if(i % 3 == 0)
                {
                    totalPrice += mousePrice;
                }
                else if(i % 2 == 0)
                {
                    totalPrice += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}