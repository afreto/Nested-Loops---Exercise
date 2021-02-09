using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJudges = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            int numOfPresentation = 0;
            double averageGradeForAllPresentation = 0;
            double averageGradeForPresentation = 0;
            while (nameOfPresentation != "Finish")
            {
                averageGradeForPresentation = 0;
                for (int i = 0; i < numOfJudges; i++)
                {
                    double gradeForPresentation = double.Parse(Console.ReadLine());
                    averageGradeForPresentation += gradeForPresentation;
                }
                numOfPresentation++;
                Console.WriteLine($"{nameOfPresentation} - {averageGradeForPresentation / numOfJudges:f2}.");
                averageGradeForAllPresentation += averageGradeForPresentation / numOfJudges;
                nameOfPresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {(averageGradeForAllPresentation / numOfPresentation):f2}.");
        }
    }
}
