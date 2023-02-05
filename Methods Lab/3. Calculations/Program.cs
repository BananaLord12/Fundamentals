namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operators = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operators)
            {
                case "add":
                    Addition(a, b);
                    break;
                case "multiply":
                    Multiplication(a, b);
                    break;
                case "subtract":
                    Subtraction(a, b);
                    break;
                case "divide":
                    Division(a, b);
                    break;
            }
        }

        static void Addition(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void Subtraction(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void Division(int a, int b)
        {
            if(b == 0)
            {
                return;
            }
            Console.WriteLine(a/b);
        }
    }
}