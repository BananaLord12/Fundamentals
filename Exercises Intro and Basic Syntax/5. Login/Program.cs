using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string actualPass = "";
            int count = 0;
            bool isuserblocked = false;
            string attempt = Console.ReadLine();
            for (int i = password.Length; i > 0; i--)
            {
                actualPass += password[i-1];
            }
            while (true)
            {

                if (attempt != actualPass)
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"User {password} blocked!");
                        isuserblocked = true;
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    attempt = Console.ReadLine();
                }
                else if (attempt == actualPass) break;
            }
            if (!isuserblocked)
            {
                Console.WriteLine($"User {password} logged in.");
            }
        }
    }
}