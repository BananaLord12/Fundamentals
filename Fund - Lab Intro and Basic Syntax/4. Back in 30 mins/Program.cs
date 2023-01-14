namespace _4._Back_in_30_mins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if(minutes + 30 >= 60)
            {
                minutes = (minutes + 30) - 60;
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
            }
            else
            {
                minutes += 30;
            }

            if(minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}