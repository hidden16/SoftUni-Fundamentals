using System;

namespace AddAndSubtract
{
    class Program
    {
        static int sumOfNums(int a, int b, int c)
        {
            a += b;
            a -= c;
            return a;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(sumOfNums(a, b, c));
        }
    }
}
