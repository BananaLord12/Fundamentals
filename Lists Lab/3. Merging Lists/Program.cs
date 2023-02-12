namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers1 = Console.ReadLine()
                .Split().Select(double.Parse).ToList();

            List<double> numbers2 = Console.ReadLine()
                .Split().Select(double.Parse).ToList();

            List<double> finalList = new List<double>();

            int highest = 0;

            for (int i = 0; i < Math.Min(numbers1.Count,numbers2.Count); i++)
            {
                finalList.Add(numbers1[i]);
                finalList.Add(numbers2[i]);
                highest = i;
            }

            if(numbers1.Count > numbers2.Count)
            {
                for (int i = Math.Min(numbers1.Count, numbers2.Count); i < Math.Max(numbers1.Count, numbers2.Count); i++)
                {
                    finalList.Add(numbers1[i]);
                }
            }
            else
            {
                for (int i = Math.Min(numbers1.Count, numbers2.Count); i < Math.Max(numbers1.Count, numbers2.Count); i++)
                {
                    finalList.Add(numbers2[i]);
                }
            }
            Console.Write(string.Join(" ", finalList.ToArray()));
        }
    }
}