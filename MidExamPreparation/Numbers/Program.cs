using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> kekw = new List<int>();
            double avgNum = 0;
            if (numbers.Count == 1)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                avgNum += numbers[i];
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (avgNum / numbers.Count == numbers[0])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < 5; i++)
            {
                if (i < numbers.Count)
                {
                    if (numbers[i] > avgNum / numbers.Count)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
        }
    }
}
