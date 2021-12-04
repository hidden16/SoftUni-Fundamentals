using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int reverse = 0;
            int test = 0;
            while (numbers != "END")
            {
                int n = int.Parse(numbers);
                int temp = n;
                reverse = 0;
                while (n != 0)
                {
                    test = n % 10;
                    reverse = reverse * 10 + test;
                    n /= 10;
                }
                if (reverse == temp)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                numbers = Console.ReadLine();
            }
        }
    }
}
