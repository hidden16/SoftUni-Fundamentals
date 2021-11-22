using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine($"\n{sum}");
        }
    }
}
