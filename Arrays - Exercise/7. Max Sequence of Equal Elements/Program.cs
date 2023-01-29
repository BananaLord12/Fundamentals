using System;

namespace _7._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int longeststart = 0;
            int longestlenght = 1;

            int currentlenght = 1;
            int currentstart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentlenght++;

                    if(currentlenght > longestlenght)
                    {
                        longestlenght = currentlenght;
                        longeststart = currentstart;
                    }
                }
                else
                {
                    currentlenght = 1;
                    currentstart = i;
                }
            }
            
            for(int i = longeststart; i < longeststart+ longestlenght; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}