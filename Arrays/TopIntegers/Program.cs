using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool biggestNum = true;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        biggestNum = false;
                        break;
                    }
                }
                if (biggestNum)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }
        }
    }
}
