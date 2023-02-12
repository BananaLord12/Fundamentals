using System;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> PlayeroneHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> PlayertwoHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while(PlayeroneHand.Count > 0 && PlayertwoHand.Count > 0) // player one 8 && player two 0
            {
                if (PlayeroneHand[0] > PlayertwoHand[0])
                {
                    PlayeroneHand.Add(PlayeroneHand[0]);
                    PlayeroneHand.Remove(PlayeroneHand[0]);

                    PlayeroneHand.Add(PlayertwoHand[0]);
                    PlayertwoHand.Remove(PlayertwoHand[0]);
                }
                else if (PlayeroneHand[0] < PlayertwoHand[0])
                {
                    PlayertwoHand.Add(PlayertwoHand[0]);
                    PlayertwoHand.Remove(PlayertwoHand[0]);

                    PlayertwoHand.Add(PlayeroneHand[0]);
                    PlayeroneHand.Remove(PlayeroneHand[0]);
                }
                else
                {
                    PlayeroneHand.Remove(PlayeroneHand[0]);
                    PlayertwoHand.Remove(PlayertwoHand[0]);
                }
            }

            if(PlayeroneHand.Count == 0)
            {
                Console.WriteLine("Second player wins! Sum: {0}",PlayertwoHand.Sum());
            }
            else
            {
                Console.WriteLine("First player wins! Sum: {0}", PlayeroneHand.Sum());
            }
        }
    }
}