using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            foreach (var elements in firstInput)
            {
                foreach (var elementsTwo in secondInput)
                {
                    if (elements == elementsTwo)
                    {
                        Console.Write($"{elements} ");
                    }
                }
            }
        }
    }
}
