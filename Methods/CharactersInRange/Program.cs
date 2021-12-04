using System;

namespace CharactersInRange
{
    class Program
    {
        static void CharactersInRange(char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                Console.Write((char)i + " ");
            }
            if (a > b)
            {
                char c;
                c = b;
                b = a;

                for (int i = c + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            CharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
    }
}
