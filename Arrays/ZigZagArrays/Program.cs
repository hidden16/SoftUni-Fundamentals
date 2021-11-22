using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numOne = new int[n];
            int[] numTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    numOne[i] = input[0];
                    numTwo[i] = input[1];
                }
                else
                {
                    numOne[i] = input[1];
                    numTwo[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", numOne));
            Console.WriteLine(string.Join(" ", numTwo));
        }
    }
}
