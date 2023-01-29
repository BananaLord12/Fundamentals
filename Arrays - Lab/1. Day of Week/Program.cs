namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[] { "Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"};
            int n = int.Parse(Console.ReadLine());
            if(n < 8 && n > 0)
            {
                Console.WriteLine(weekDays[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}