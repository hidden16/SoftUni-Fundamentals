using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void SmallestOfThreeNumbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        static void Main(string[] args)
        {
            SmallestOfThreeNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
    }
}
