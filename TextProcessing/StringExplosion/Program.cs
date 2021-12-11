using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (bomb > 0 && word[i] != '>')
                {
                    word = word.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (word[i] == '>')
                {
                    bomb += int.Parse(word[i + 1].ToString());
                }
            }
            Console.WriteLine(word);
        }
    }
}
