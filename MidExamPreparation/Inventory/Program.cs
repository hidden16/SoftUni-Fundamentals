using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string[] input = Console.ReadLine().Split(" - ").ToArray();
            while (input[0] != "Craft!")
            {
                if (input[0] == "Collect")
                {
                    if (items.Contains(input[1]))
                    {

                    }
                    else
                    {
                        items.Add(input[1]);
                    }
                }
                if (input[0] == "Drop")
                {
                    if (items.Contains(input[1]))
                    {
                        items.Remove(input[1]);
                    }
                }
                if (input[0] == "Combine Items")
                {
                    string[] splitter = input[1].Split(":");

                    if (items.Contains(splitter[0]))
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i] == splitter[0])
                            {
                                items.Insert(i + 1, splitter[1]);
                            }
                        }
                    }
                }
                if (input[0] == "Renew")
                {
                    if (items.Contains(input[1]))
                    {
                        items.Add(input[1]);
                        items.Remove(input[1]);
                    }
                }
                input = Console.ReadLine().Split(" - ").ToArray();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
