namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end") { break; }
                string[] tokens = input.Split();

                if (tokens[0] == "Add")
                {
                    wagons.Add(int.Parse(tokens[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(tokens[0]) <= maxCapWagon)
                        {
                            wagons.Insert(i, wagons[i] + int.Parse(tokens[0]));
                            wagons.RemoveAt(i+1);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}