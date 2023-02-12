using System;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Minefield = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> Bombpower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < Minefield.Where(x => x == Bombpower[0]).ToList().Count; i++)
            {
                List<int> bombpositions = Enumerable.Range(0, Minefield.Count).Where(x => Minefield[x] == Bombpower[0]).ToList();
                Minefield.RemoveRange(Math.Max(0, bombpositions[i] - Bombpower[1]),Math.Min(Minefield.Count - bombpositions[i] + Bombpower[1], Bombpower[1]*2+1));
                i = -1;
            }
            Console.WriteLine(Minefield.Sum());
        }
    }
}