using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= number; i++)
            {
                char test = char.Parse(Console.ReadLine());

                int testA = test;

                sum += testA;

            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
