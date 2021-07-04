using System;
using System.Collections.Generic;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            double maxStudentBonus = 0;
            double maxStudAttendance = 0;

            List<double> studentAttendances = new List<double>();
            List<double> studentBonuses = new List<double>();

            for (double i = 0; i < studentsCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount * (5 + initialBonus);
                studentAttendances.Add(studentAttendance);
                studentBonuses.Add(totalBonus);
            }

            int maxBonusIndex = 0;
            for (int i = 0; i < studentBonuses.Count; i++)
            {
                if (studentBonuses[i] > studentBonuses[maxBonusIndex])
                {
                    maxBonusIndex = i;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(studentBonuses[maxBonusIndex])}.");
            Console.WriteLine($"The student has attended {Math.Ceiling(studentAttendances[maxBonusIndex])} lectures.");
        }
    }
}
