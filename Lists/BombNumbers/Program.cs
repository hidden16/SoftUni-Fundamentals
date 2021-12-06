using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string bombSpec = Console.ReadLine();
            int[] bombSpecsAsInt = bombSpec.Split(' ').Select(int.Parse).ToArray();
            int bomb = bombSpecsAsInt[0];
            int bombPower = bombSpecsAsInt[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bomb)
                {
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
                    i = startIndex - 1;
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}