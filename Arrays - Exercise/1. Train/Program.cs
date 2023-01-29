using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   int n = int.Parse(Console.ReadLine());
                   int[] passengerinwagos = new int[n];
                   int sum = 0;

                   for (int i = 0; i < n; i++)
                   {
                       int num = int.Parse(Console.ReadLine());
                       passengerinwagos[i] = num;
                       sum += num;
                   }
                   foreach(int num in passengerinwagos)
                   {
                       Console.Write(num + " ");
                   }
                   Console.WriteLine("\n"+sum);
        }
    }
}