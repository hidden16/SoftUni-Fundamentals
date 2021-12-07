using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double total = 0;
            int student = 0;
            for (int i = 1; i <= numberOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                total = ((double)attendances / (double)numOfLectures) * (5 + additionalBonus);
                if (total > maxBonus)
                {
                    maxBonus = total;
                    student = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.\nThe student has attended {student} lectures.");
        }
    }
}
