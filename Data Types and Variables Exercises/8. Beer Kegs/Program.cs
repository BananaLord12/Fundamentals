using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double[] kegsV = new double[kegs];
            string[] kegsNames = new string[kegs];
            for (int i = 0; i < kegs; i++)
            {
                string kegName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                kegsNames[i] = kegName;

                kegsV[i] = Math.PI * Math.Pow(radius, 2) * height;

            }
            double volume = kegsV.Max();
            int index = Array.IndexOf(kegsV, volume);
            Console.WriteLine(kegsNames[index]);
        }
    }
}