using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(" ");

                if (tokens[0] == "Add")
                {
                    int wagonToAdd = int.Parse(tokens[1]);

                    train.Add(wagonToAdd);
                }
                else
                {
                    int numberToAdd = int.Parse(input);

                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagon = train[i];

                        if (currentWagon + numberToAdd <= maxCapacity)
                        {
                            train[i] += numberToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}