using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> collection = new Dictionary<string, List<string>>();
        string piece = string.Empty;
        string composer = string.Empty;
        string key = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            piece = data[0];
            composer = data[1];
            key = data[2];

            collection.Add(piece, new List<string>() { "", "" });
            collection[piece][0] = composer;
            collection[piece][1] = key;

        }

        while (true)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "Stop") break;

            string action = input[0];
            piece = input[1];


            if (action == "Add")
            {
                composer = input[2];
                key = input[3];
                if (collection.ContainsKey(piece))
                {
                    Console.WriteLine($"{piece} is already in the collection!");
                    continue;
                }


                collection.Add(piece, new List<string>() { "", "" });
                collection[piece][0] = composer;
                collection[piece][1] = key;
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");


            }
            else if (action == "Remove")
            {

                if (!collection.ContainsKey(piece))
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    continue;
                }



                collection.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");


            }
            else if (action == "ChangeKey")
            {
                string newKey = input[2];
                if (!collection.ContainsKey(piece))
                {
                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    continue;

                }

                collection[piece][1] = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
        }


        for (int i = 0; i < collection.Count; i++)
        {

        }

        foreach (var item in collection)
        {


            

        }
    }
}