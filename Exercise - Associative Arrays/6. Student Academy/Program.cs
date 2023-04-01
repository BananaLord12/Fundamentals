using System;

namespace _6._Student_Academy
{
    internal class Program
    {
        public static Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string toInsert = "";

            for (int i = 0; i < n*2; i++)
            {
                string input = Console.ReadLine();
                if(i % 2 == 0)
                {
                    if (grades.ContainsKey(input))
                    {
                        toInsert = input;
                        continue;
                    }
                    else
                    {
                        grades.Add(input, new List<double>());
                        toInsert = input;
                    }
                    
                }
                else
                {
                    grades[toInsert].Add(double.Parse(input));
                }
            }

            foreach(var grade in grades)
            {
                if(grade.Value.Average(x => x) >= 4.5) 
                {
                    Console.WriteLine($"{grade.Key} -> {grade.Value.Average(x => x):F2}");
                }
            }
        }
    }
}