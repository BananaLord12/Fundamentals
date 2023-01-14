using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] validCoins = new double[] { 0.1, 0.2, 0.5, 1, 2 };
            double customerSum = 0;
            while (true)
            {
                string coin = Console.ReadLine();
                if(coin == "Start")
                {
                    break;
                }
                if(!validCoins.Contains(double.Parse(coin)))
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    continue;
                }
                customerSum += double.Parse(coin);
            }

            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End") break;
                switch (product)
                {
                    case "Nuts":
                        if (customerSum - 2.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        customerSum -= 2.0;
                        Console.WriteLine($"Purchased nuts");
                        break;
                    case "Water":
                        if (customerSum - 0.7 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        customerSum -= 0.7;
                        Console.WriteLine($"Purchased water");
                        break;
                    case "Crisps":
                        if (customerSum - 1.5 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        customerSum -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                        break;
                    case "Soda":
                        if (customerSum - 0.8 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        customerSum -= 0.8;
                        Console.WriteLine($"Purchased soda");
                        break;
                    case "Coke":
                        if (customerSum - 1.0 < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        customerSum -= 1.0;
                        Console.WriteLine($"Purchased coke");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {customerSum:F2}");
        }
    }
}