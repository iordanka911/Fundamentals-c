using System;

namespace _1._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal dollars = britishPounds * 1.31M;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
