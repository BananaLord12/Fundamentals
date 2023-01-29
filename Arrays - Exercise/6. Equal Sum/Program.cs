using System;

namespace _6._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftsum = 0;
            int rightsum = 0;
            int index = 0;
            bool valid = false;

            foreach(int num in arr)
            {
                //get index for current number
                index = Array.IndexOf(arr, num);
                leftsum = 0; rightsum = 0;

                if (index == 0)
                {
                    leftsum = 0;
                } else if (index == arr.Length)
                    rightsum = 0;
                //left sum
                if(index != 0)
                {
                    for (int i = index-1; i >= 0; i--)
                    {
                        leftsum += arr[i];
                    }
                }

                //right sum
                if(index != arr.Length)
                {
                    for (int i = index+1; i < arr.Length; i++)
                    {
                        rightsum += arr[i];
                    }
                }

                if(leftsum == rightsum)
                {
                    Console.WriteLine(index);
                    valid = true;
                    break;
                }
            }
            if (!valid)
            {
                Console.WriteLine("no");
            }
        }
    }
}