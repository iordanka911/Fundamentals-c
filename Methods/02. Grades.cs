using System;

namespace integerSign
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSign(number);
        }

        static void PrintNumberSign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number==0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
