using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / capacity);
            if (capacity > people)
            {
                Console.WriteLine(courses);
            }
            else if (people > capacity)
            {
                Console.WriteLine(courses);
            }

        }
    }
}
