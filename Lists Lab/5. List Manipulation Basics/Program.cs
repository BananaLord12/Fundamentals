namespace _5._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> originalNumbers = numbers;
            bool isChangesDone = false;

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        originalNumbers.Add(int.Parse(tokens[1]));
                        isChangesDone = true;
                        break;
                    case "Remove":
                        originalNumbers.Remove(int.Parse(tokens[1]));
                        isChangesDone = true;
                        break;
                    case "RemoveAt":
                        originalNumbers.RemoveAt(int.Parse(tokens[1]));
                        isChangesDone = true;
                        break;
                    case "Insert":
                        originalNumbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        isChangesDone = true;
                        break;
                    case "Contains":
                        if (originalNumbers.Contains(int.Parse(tokens[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else { Console.WriteLine("No such number"); }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < originalNumbers.Count; i++)
                        {
                            if (originalNumbers[i] % 2 == 0)
                            {
                                Console.Write(originalNumbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < originalNumbers.Count; i++)
                        {
                            if (originalNumbers[i] % 2 == 1)
                            {
                                Console.Write(originalNumbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        double sum = 0;
                        for (int i = 0; i < originalNumbers.Count; i++)
                        {
                            sum += originalNumbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        switch (tokens[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", originalNumbers.Where(x => x < int.Parse(tokens[2]))));
                                break;
                            case ">":
                                Console.WriteLine(string.Join(" ", originalNumbers.Where(x => x > int.Parse(tokens[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(" ", originalNumbers.Where(x => x >= int.Parse(tokens[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(" ", originalNumbers.Where(x => x <= int.Parse(tokens[2]))));
                                break;
                        }
                        break;
                }
            }
            if(!isChangesDone)
            {

            }
            else
            {
                Console.WriteLine(string.Join(" ", originalNumbers));
            }

        }
    }
}