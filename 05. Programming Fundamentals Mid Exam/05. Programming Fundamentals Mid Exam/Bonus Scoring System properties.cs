using System;
using System.Collections.Generic;

namespace ConsoleApp89
{
    class Student
    {
       public int Attendance { get; set; }

       public double Bonus { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            double maxStudentBonus = 0;
            double maxStudAttendance = 0;

            List<Student> students = new List<Student>();
           

            for (double i = 0; i < studentsCount; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / lecturesCount * (5 + initialBonus);
              students.Add(new Student()
              {
                  Attendance = (int)studentAttendance,
                  Bonus=totalBonus
              });
            }

            int maxBonusIndex = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Bonus>students[maxBonusIndex].Bonus)
                {
                    maxBonusIndex = i;
                }
            }

            if (studentsCount==0)
            {
                Console.WriteLine($"Max Bonus: {0}.");
                Console.WriteLine($"The student has attended 0 lectures.");
            }
        
            else
            {
                Console.WriteLine($"Max Bonus: {Math.Ceiling(students[maxBonusIndex].Bonus)}.");
                Console.WriteLine($"The student has attended {(students[maxBonusIndex].Attendance)} lectures.");
            }
        }
           
        
    }
}
