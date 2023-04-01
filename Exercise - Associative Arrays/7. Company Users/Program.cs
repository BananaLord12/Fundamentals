namespace _7._Company_Users
{
    internal class Program
    {

        public static Dictionary<string, List<string>> Companies = new Dictionary<string, List<string>>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "End")
            {
                string[] token = input.Split(" -> ");

                if (Companies.ContainsKey(token[0]) && Companies[token[0]].Contains(token[1]))
                {
                    input = Console.ReadLine();
                    continue;
                }else if (Companies.ContainsKey(token[0]))
                {
                    Companies[token[0]].Add(token[1]);
                    input = Console.ReadLine();
                    continue;
                }
                Companies.Add(token[0], new List<string>());
                Companies[token[0]].Add(token[1]);
                input = Console.ReadLine();
            }

            foreach(var company in Companies)
            {
                Console.WriteLine(company.Key);
                foreach(var id in company.Value.ToList())
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}