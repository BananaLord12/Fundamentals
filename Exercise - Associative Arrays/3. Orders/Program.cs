namespace _3._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, int> products = new Dictionary<string, int>();
            List<double> price = new List<double>();


            string input = Console.ReadLine();
            while(input != "buy") 
            {
                string[] token = input.Split().ToArray();

                if (products.ContainsKey(token[0])) 
                {
                    products[token[0]] += int.Parse(token[2]);
                    int index = products.Keys.ToList().IndexOf(token[0]);

                    if (price[index] != double.Parse(token[1]))
                    {
                        price[index] = double.Parse(token[1]);
                    }
                }
                else
                {
                    price.Add(double.Parse(token[1]));
                    products.Add(token[0], int.Parse(token[2]));
                }
                input = Console.ReadLine();
            }
            int count = 0;
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Key} -> {(product.Value * price[count]):F2}");

                count++;
            }
        }
    }
}