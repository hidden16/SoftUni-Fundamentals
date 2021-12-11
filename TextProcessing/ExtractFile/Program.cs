using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = Console.ReadLine().Split("\\");
            string splitted = file[file.Length - 1];
            string[] extension = splitted.Split(".");
            Console.WriteLine($"File name: {extension[0]}");
            Console.WriteLine($"File extension: {extension[1]}");
        }
    }
}
