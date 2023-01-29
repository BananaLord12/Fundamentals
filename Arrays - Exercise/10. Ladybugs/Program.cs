using System;

namespace _10._Ladybugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fieldsize = new int[n];
            bool isladybugout = false;
            string command = "";

            int[] initialpos = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach(int ladybyg in initialpos)
            {
                if (ladybyg < 0 || ladybyg >= fieldsize.Length)
                {
                    continue;
                }
                fieldsize[ladybyg] = 1;
            }

            while (fieldsize.Length > 0)
            {
                command = Console.ReadLine();
                if (command == "end") break;
                string[] instructions = command.Split(" ");
                int originalpos = int.Parse(instructions[0]);
                int currentpos = int.Parse(instructions[0]);
                isladybugout = false;

                if (int.Parse(instructions[2]) < 0) //flight
                {
                    instructions[2] = Math.Abs(int.Parse(instructions[2])).ToString();
                    if (instructions[1] == "left") instructions[1] = "right";
                    else instructions[1] = "left";
                }

                if ((currentpos >= fieldsize.Length || currentpos < 0) || fieldsize[currentpos] == 0) continue;

                switch (instructions[1])
                {
                    case "left":
                        currentpos -= int.Parse(instructions[2]);
                        if (int.Parse(instructions[2]) == 0) break;

                        if (currentpos < 0)
                        {
                            fieldsize[originalpos] = 0;
                            break;
                        }

                        while (fieldsize[currentpos] == 1)
                        {
                            currentpos -= int.Parse(instructions[2]);
                            if (currentpos < 0)
                            {
                                fieldsize[originalpos] = 0;
                                isladybugout = true;
                                break;
                            }
                        }

                        if (!isladybugout)
                        {
                            fieldsize[currentpos] = 1;
                            fieldsize[originalpos] = 0;
                        }

                        break;
                    case "right":
                        currentpos += int.Parse(instructions[2]); //new pos
                        if (int.Parse(instructions[2]) == 0) break;

                        if (currentpos >= fieldsize.Length)
                        {
                            fieldsize[originalpos] = 0;
                            break;
                        }

                        while (fieldsize[currentpos] == 1)
                        {
                            currentpos += int.Parse(instructions[2]); //new pos
                            if (currentpos >= fieldsize.Length)
                            {
                                fieldsize[originalpos] = 0;
                                isladybugout = true;
                                break;
                            }
                        }

                        if (!isladybugout)
                        {
                            fieldsize[currentpos] = 1;
                            fieldsize[originalpos] = 0;
                        }

                        break;
                }
            }
            foreach(int ladybug in fieldsize)
            {
                Console.Write(ladybug + " ");
            }
        }
    }
}