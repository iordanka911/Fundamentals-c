using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!student.ContainsKey(studentName))
                {
                    student.Add(studentName,new List<double>());
                }
                student[studentName].Add(grade);
               
            }
           

            foreach (var studentName in student.OrderByDescending(x=>x.Value.Average()))
            {

                if (studentName.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{studentName.Key} -> {studentName.Value.Average():F2}");
                }
                
            }
        }
    }
}
