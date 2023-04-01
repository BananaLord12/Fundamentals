namespace _4._SoftUni_Parking
{
    internal class Program
    {
        public static Dictionary<string, string> carPark = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split().ToArray();

                switch (token[0])
                {
                    case "register":

                        if(carPark.ContainsKey(token[1]))
                        {
                            string license = carPark[token[1]];
                            Console.WriteLine($"ERROR: already registered with plate number {license}");
                        }
                        else
                        {
                            carPark.Add(token[1], token[2]);
                            Console.WriteLine($"{token[1]} registered {token[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!carPark.ContainsKey(token[1]))
                        {
                            Console.WriteLine($"ERROR: user {token[1]} not found");
                        }
                        else
                        {
                            carPark.Remove(token[1]);
                            Console.WriteLine($"{token[1]} unregistered successfully");
                        }
                        break;
                }
            }
            foreach(var car in carPark)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}