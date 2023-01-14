using System;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] snow = new int[n];
            int[] time = new int[n];
            int[] quality = new int[n];
            double[] Value = new double[n];
            List<double> value = new List<double>();

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snow[i] = snowballSnow;
                time[i] = snowballTime;
                quality[i] = snowballQuality;
                Value[i] = Math.Pow((snowballSnow / snowballTime),snowballQuality);
                value.Add(Value[i]);
            }
            double val = value.Max();
            int index = Array.IndexOf(Value,val);
            Console.WriteLine($"{snow[index]} : {time[index]} = {Value[index]} ({quality[index]})");
        }
    }
}