using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplecount = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = peoplecount * (decimal)8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = peoplecount * (decimal)9.80;
                    }
                    else
                    {
                        price = peoplecount * (decimal)10.46;
                    }
                    if (peoplecount >= 30)
                    {
                        price *= (decimal)0.85;
                    }
                    break;
                case "Business":
                    if (peoplecount >= 100)
                    {
                        peoplecount -= 10;
                    }
                    if (day == "Friday")
                    {
                        price = peoplecount * (decimal)10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = peoplecount * (decimal)15.60;
                    }
                    else
                    {
                        price = peoplecount * (decimal)16.0;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = peoplecount * (decimal)15.0;
                    }
                    else if (day == "Saturday")
                    {
                        price = peoplecount * (decimal)20.0;
                    }
                    else
                    {
                        price = peoplecount * (decimal)22.50;
                    }
                    if (peoplecount >= 10 && peoplecount <= 20)
                    {
                        price *= (decimal)0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}