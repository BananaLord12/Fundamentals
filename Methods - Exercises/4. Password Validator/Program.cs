using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            CheckPassword(password);

        }

        private static void CheckPassword(string password)
        {
            bool isPassValid = true;

            if (password.Length < 6 || password.Length > 10)
            {
                isPassValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            int digitcount = 0;
            bool isSymbolPresent = false;
            foreach (char c in password)
            {
                if(char.IsDigit(c)) digitcount++;
                if(!char.IsLetterOrDigit(c)) isSymbolPresent = true;
            }
            if (isSymbolPresent)
            {
                isPassValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (digitcount < 2)
            {
                isPassValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (isPassValid)
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}