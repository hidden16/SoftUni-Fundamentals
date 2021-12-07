using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double number = 0.0;
            double sum = 0.0;
            while (input != "regular" && input != "special")
            {
                number = double.Parse(input);
                if (number <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += number;
                }
                input = Console.ReadLine();
            }
            double tax = sum * 0.2;
            double total = sum + tax;
            if (input == "special")
            {
                total = total - (total * 0.1);
            }
            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {sum:f2}$\nTaxes: {tax:f2}$\n-----------\nTotal price: {total:f2}$");
                return;
            }
        }
    }
}
