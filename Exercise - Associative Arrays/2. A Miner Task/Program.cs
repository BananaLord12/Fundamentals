using System.Numerics;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> valuables = new Dictionary<string, BigInteger>();

            string input = Console.ReadLine();
            string toInsert = "";
            int count = 1;

            while (input != "stop")
            {
                if (count % 2 == 0)
                {
                    if (valuables.ContainsKey(toInsert))
                    {
                        valuables[toInsert] += BigInteger.Parse(input);
                        input = Console.ReadLine();
                        count++;
                        continue;
                    }
                }
                else
                {
                    if (valuables.ContainsKey(input))
                    {
                        toInsert = input;
                        input = Console.ReadLine();
                        count++;
                        continue;
                    }
                    else
                    {
                        valuables.Add(input, 0);
                        toInsert = input;
                        input = Console.ReadLine();
                        count++;
                        continue;
                    }
                }
                toInsert = input;
                input = Console.ReadLine();
                count++;
            }

            foreach (var valuable in valuables)
            {
                Console.WriteLine($"{valuable.Key} -> {valuable.Value}");
            }
        }
    }
}