using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if (sum + litersToPour > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                }
                else
                {
                    sum += litersToPour;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
