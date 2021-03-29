using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            Increment(number, 2);
            Console.WriteLine(number);
        }
        static void Increment(int number, int inc)
        {
            number += inc;
        }

    }
}
