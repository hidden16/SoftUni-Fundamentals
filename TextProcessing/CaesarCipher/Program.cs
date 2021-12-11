using System;

namespace CaesarSipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split("", StringSplitOptions.RemoveEmptyEntries);
            char[] ch = new char[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                ch = words[i].ToCharArray();
            }
            foreach (char item in ch)
            {
                Console.Write((char)(item + 3));
            }
        }
    }
}
