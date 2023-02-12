namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestsList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split();

                if (token[2] == "going!")
                {
                    if (guestsList.Contains(token[0]))
                    {
                        Console.WriteLine($"{token[0]} is already in the list!");
                        continue;
                    }
                    guestsList.Add(token[0]);
                }
                else
                {
                    if (!guestsList.Contains(token[0]))
                    {
                        Console.WriteLine($"{token[0]} is not in the list!");
                        continue;
                    }
                    guestsList.Remove(token[0]);
                }
            }
            foreach(string guest in guestsList)
            {
                Console.WriteLine(guest);
            }
            
        }
    }
}