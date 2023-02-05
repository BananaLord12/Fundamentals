using System;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }
                string isokay = IsIntegerPalindrome(input);
                Console.WriteLine(isokay);
            }
        }

        private static string IsIntegerPalindrome(string input)
        {
            string originalinput = input;
            string reverseint = string.Join("",input.ToCharArray().Reverse());

            if(reverseint == originalinput)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}