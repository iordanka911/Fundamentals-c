using System;
using System.Collections.Generic;

namespace SumOfDigits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);
            Console.WriteLine(courses);
        }
    }
}
