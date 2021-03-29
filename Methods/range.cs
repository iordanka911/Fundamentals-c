using System;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRange();
            PrintRange(10);
            PrintRange(10, 87);

        }
        static void PrintRange(int start=0, int end=100)
        {
            Console.WriteLine($"Range is from {start} to {end}");
        }
    }
}
