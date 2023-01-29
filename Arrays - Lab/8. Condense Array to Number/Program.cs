using System;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (arr1.Length > 1)
            {
                int[] condensed = new int[arr1.Length - 1];
                for (int i = 0; i < arr1.Length - 1; i++)
                {                   
                    condensed[i] = arr1[i] + arr1[i + 1];
                }                
                arr1 = condensed;

            }
            Console.WriteLine(arr1[0]);*/

            int lostgames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            totalPrice = ((lostgames / 2) * headsetPrice) + ((lostgames / 3) * mousePrice) + ((lostgames / 6) * keyboardPrice) + ((lostgames / 12) * displayPrice);
            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
        }
    }
}