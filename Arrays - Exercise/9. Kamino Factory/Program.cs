using System;
using System.Linq;

namespace _9._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] bestDNA = null;
            int bestLenght = -1;
            int startIndex = -1;
            int bestDnasum = 0;
            int bestSampleIndex = 0;

            int currentSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!") break;

                string[] currentDNA = input.Split("!");
                int currentLength = 0;
                int currentBestLen = 0;
                int currentEndIndex = 0;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == "1")
                    {
                        currentLength++;

                        if(currentLength > currentBestLen)
                        {
                            currentEndIndex = i;
                            currentBestLen = currentLength;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }

                int currentStartIndex = currentEndIndex - currentBestLen + 1;

                bool isCurrentDNABetter = false;
                int currentDnaSum = currentDNA.Select(int.Parse).Sum();

                if(currentBestLen > bestLenght)
                {
                    isCurrentDNABetter = true;
                }else if(currentBestLen == bestLenght)
                {
                    if(currentStartIndex < startIndex)
                    {
                        isCurrentDNABetter = true;
                    }
                    else if(currentStartIndex == startIndex)
                    {
                        if(currentDnaSum > bestDnasum)
                        {
                            isCurrentDNABetter = true;
                        }
                    }
                }

                currentSampleIndex++;

                if (isCurrentDNABetter)
                {
                    bestDNA = currentDNA;
                    bestLenght = currentBestLen;
                    startIndex = currentStartIndex;
                    bestDnasum = currentDnaSum;
                    bestSampleIndex = currentSampleIndex;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestDnasum}.");
            Console.WriteLine(string.Join(' ', bestDNA));
        }
    }
}