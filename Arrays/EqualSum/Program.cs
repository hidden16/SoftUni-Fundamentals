using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                //leftSum
                leftSum = 0;
                for (int left = i; left < numbers.Length; left++)
                {
                    int elementsLeft = left + 1;
                    if (left < numbers.Length - 1)
                    {
                        leftSum += numbers[elementsLeft];
                    }
                }
                //rightSum
                rightSum = 0;
                for (int right = i; right > 0; right--)
                {
                    int elementsRight = right - 1;
                    if (right > 0)
                    {
                        rightSum += numbers[elementsRight];
                    }
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
