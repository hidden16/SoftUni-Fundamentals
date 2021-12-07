using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstIndex = 0;
            int secondIndex = 0;
            string[] input = Console.ReadLine().Split().ToArray();
            int counter = 0;
            while (input[0] != "End")
            {
                firstIndex = int.Parse(input[1]);
                secondIndex = int.Parse(input[2]);
                if (input[0] == "Shoot")
                {
                    if (firstIndex >= 0 && firstIndex < numbers.Count)
                    {
                        numbers[firstIndex] -= secondIndex;
                        if (numbers[firstIndex] <= 0)
                        {
                            numbers.RemoveAt(firstIndex);
                        }
                        if (numbers.Count == 0)
                        {
                            return;
                        }
                    }
                }
                else if (input[0] == "Add")
                {
                    if (firstIndex >= 0 && firstIndex < numbers.Count)
                    {
                        numbers.Insert(firstIndex, secondIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (input[0] == "Strike")
                {
                    if (firstIndex - secondIndex >= 0 && firstIndex + secondIndex < numbers.Count)
                    {
                        for (int i = 0; i < secondIndex; i++)
                        {
                            numbers.RemoveRange(firstIndex - secondIndex, secondIndex * 2 + 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join("|", numbers));
        }
    }
}
