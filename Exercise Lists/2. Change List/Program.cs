namespace _2._Change_List
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
                if (input == "end") { break; }
                string[] token = input.Split();

                switch (token[0])
                {
                    case "Delete":
                        numbers.RemoveAll(item => item.ToString() == token[1]);
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(token[2]), int.Parse(token[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}