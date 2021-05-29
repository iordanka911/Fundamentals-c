using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmplyeeEficiency = int.Parse(Console.ReadLine());
            int secondEmplyeeEficiency = int.Parse(Console.ReadLine());
            int thirdEmplyeeEficiency = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int studentPerHour = firstEmplyeeEficiency + secondEmplyeeEficiency + thirdEmplyeeEficiency;

            int hours = (int)Math.Ceiling(students / (double)studentPerHour);
            int breakTime = hours / 3;

            if (hours%3==0&&breakTime>0)
            {
                breakTime--;
            }

            Console.WriteLine($"Time needed: {hours+breakTime}h.");

        }
    }
}
