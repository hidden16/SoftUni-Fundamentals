using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split().ToArray();
            int indexOne = 0;
            int indexTwo = 0;
            while (input[0] != "end")
            {
                if (input[0] == "swap")
                {
                    indexOne = int.Parse(input[1]);
                    indexTwo = int.Parse(input[2]);

                    if (indexOne > indexTwo)
                    {
                        int test = numbers[indexOne];
                        numbers.RemoveAt(indexOne);
                        numbers.Insert(indexOne, numbers[indexTwo]);
                        numbers.RemoveAt(indexTwo);
                        numbers.Insert(indexTwo, test);
                    }
                    else
                    {
                        int test = numbers[indexTwo];
                        numbers.RemoveAt(indexTwo);
                        numbers.Insert(indexTwo, numbers[indexOne]);
                        numbers.RemoveAt(indexOne);
                        numbers.Insert(indexOne, test);
                    }
                }
                else if (input[0] == "multiply")
                {
                    indexOne = int.Parse(input[1]);
                    indexTwo = int.Parse(input[2]);

                    numbers[indexOne] *= numbers[indexTwo];
                }
                else if (input[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
