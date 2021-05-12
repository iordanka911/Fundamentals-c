using System;
using System.Collections.Generic;
using System.Numerics;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan","Petrov");
            Student student2 = new Student("Petar", "Petrov");
            Student student3 = new Student("Geogi", "Petrov");
            student1.FirstName = "Ivan";
            student1.LastName = "Petrov";
            string learn = student1.Learning("Mathematics");

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            Student currentStudent = students[0];
            Student secondStudent = students[2];
            students[2] = currentStudent;
            students[0] = secondStudent;
            foreach (Student curentStudent in students)
            {
                Console.WriteLine(curentStudent.LastName);
            }
            Console.WriteLine(learn);
            Console.WriteLine($"Hello my name is {student1.FirstName} {student1.LastName}.");

        }
       
    }
    public class Student
    {
        private string firstName;
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student() : base()
        {

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Learning(string subject)
        {
            return $"I'm learnig {subject}";
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
