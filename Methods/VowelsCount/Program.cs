using System;

namespace VowelsCount
{
    class Program
    {
        static void VowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            VowelsCount(Console.ReadLine());
        }
    }
}
