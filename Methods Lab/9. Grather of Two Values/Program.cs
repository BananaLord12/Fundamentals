using System;

namespace _9._Grather_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int result = GetMax(a, b);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char a1 = char.Parse(Console.ReadLine());
                    char b1 = char.Parse(Console.ReadLine());
                    char result1 = GetMax(a1, b1);
                    Console.WriteLine(result1);
                    break;
                case "string":
                    string a2 = Console.ReadLine();
                    string b2 = Console.ReadLine();
                    string result2 = GetMax(a2, b2);
                    Console.WriteLine(result2);
                    break;
            }

        }

        private static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        private static char GetMax(char a, char b)
        {
            if (a == b) return a;
            if(a>b)
            {
                return a;
            }
            else { return b; }
        }

        private static string GetMax(string a, string b)
        {
            int result = string.Compare(a, b);
            if (result > 0) return a;
            if (result < 0) return b;
            else return a;
            
        }
    }
}