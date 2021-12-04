using System;
using System.Linq;
namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Summarise(number);
        }
        static void Summarise(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitDivisibleByEight(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;
                }

                number /= 10;
            }
            return false;
        }
        static bool IsDigitDivisibleByEight(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }
            if (digitSum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
