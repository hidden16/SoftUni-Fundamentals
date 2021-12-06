using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);

                    numbers.Add(numberToAdd);
                }

                if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numberToInsert);

                }

                if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }

                if (tokens[0] == "Shift")
                {
                    int timesToShift = int.Parse(tokens[2]);

                    if (tokens[1] == "left")
                    {

                        for (int i = 1; i < timesToShift % numbers.Count; i++)
                        {
                            int firstNum = numbers[0];

                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }

                            numbers[numbers.Count - 1] = firstNum;
                        }

                    }
                    else
                    {
                        for (int i = 0; i < timesToShift % numbers.Count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];

                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }

                            numbers[0] = lastNum;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}