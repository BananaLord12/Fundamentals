using System;
using System.IO;

namespace _3._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Console.ReadLine()
                .Split("\\")
                .ToArray();

            string[] file = files[files.Length-1].Split(".").ToArray();
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}