using System;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rng = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string phrase = "";
                string Event = "";
                string author = "";
                string city = "";
                for (int j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0: //phrases
                            phrase = phrases[rng.Next(0, phrases.Length)];
                            break;
                        case 1: //events
                            Event = events[rng.Next(0, events.Length)];
                            break;
                        case 2: //authors
                            author = authors[rng.Next(0, authors.Length)];
                            break;
                        case 3: //cities
                            city = cities[rng.Next(0, cities.Length)];
                            break;
                    }
                }
                Console.WriteLine($"{phrase} {Event} {author} - {city}");
            }
        }
    }
}