using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int shotTargets = 0;
            string input = Console.ReadLine();
            int index = 0;
            while (input != "End")
            {
                index = int.Parse(input);
                if (index < numbers.Count)
                {
                    int temp = numbers[index];
                    if (numbers[index] == -1)
                    {

                    }
                    else
                    {
                        numbers[index] = -1;
                        shotTargets++;
                    }
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > temp)
                        {
                            numbers[i] -= temp;
                        }
                        else if (numbers[i] <= temp && numbers[i] >= 0)
                        {
                            numbers[i] += temp;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.Write($"Shot targets: {shotTargets} -> ");
            Console.Write(string.Join(" ", numbers));
        }
    }
}
