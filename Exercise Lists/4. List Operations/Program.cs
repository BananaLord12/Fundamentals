namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End") { break; }
                string[] tokens = input.Split();

                switch(tokens[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        if (int.Parse(tokens[2]) < 0 || int.Parse(tokens[2]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        if (int.Parse(tokens[1]) < 0 || int.Parse(tokens[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Shift":
                        if (tokens[1] == "left") //left
                        {
                            for (int i = 0; i < int.Parse(tokens[2]); i++)
                            {
                                int first = numbers[0];
                                for (int j = 0; j < numbers.Count-1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                                numbers[numbers.Count - 1] = first;
                            }
                        }
                        else //right
                        {
                            for (int i = 0; i < int.Parse(tokens[2]); i++)
                            {
                                int last = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = last;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}