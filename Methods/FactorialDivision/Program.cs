using System;

namespace FactorialDivision
{
    class Program
    {
        static void Result(double numberOne, double numberTwo)
        {
            double temp = numberOne;

            for (double i = temp - 1; i > 0; i--)
            {
                temp *= i;
            }
            double secondTemp = numberTwo;
            for (double i = secondTemp - 1; i > 0; i--)
            {
                secondTemp *= i;
            }
            Console.WriteLine($"{temp / secondTemp:f2}");
        }
        static void Main(string[] args)
        {
            Result(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }
    }
}
