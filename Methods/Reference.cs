using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8 };
            Increment(numbers, 2);
            Console.WriteLine(numbers[0]);
        }
        static void Increment(int[] nums, int inc)
        {
            nums[0] += inc;
        }

    }
}
