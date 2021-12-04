using System;

namespace MiddleCharacters
{
    class Program
    {
        static void MiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
            else
            {
                Console.Write(input[input.Length / 2]);
            }
        }
        static void Main(string[] args)
        {
            MiddleCharacter(Console.ReadLine());

        }
    }
}
