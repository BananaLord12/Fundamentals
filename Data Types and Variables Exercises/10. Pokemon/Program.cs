using System;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int poketargers = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int pokedCount = 0;
            double halfpokePower = pokePower * 0.5;

            while(pokePower >= poketargers)
            {
                pokePower -= poketargers;
                pokedCount++;
                if (pokePower == halfpokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }               
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedCount);
        }
    }
}