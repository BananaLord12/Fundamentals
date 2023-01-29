using System;

namespace _5._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> validNums = new List<int>();
            bool isokay = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                isokay = true;
                for (int j = i; j < arr.Length-1; j++)
                {
                    if(temp > arr[j+1])
                    {
                        continue;
                    }
                    else { isokay = false; break; }
                }
                if(isokay)
                validNums.Add(temp);
            }
            foreach (int num in validNums)
            {
                Console.Write(num + " ");
            }
        }
    }
}