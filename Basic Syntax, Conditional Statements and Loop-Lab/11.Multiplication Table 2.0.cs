using System;

namespace Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            for (int times = multiplier; times <=10; times++)
            {
                Console.WriteLine($"{integer} X {times} = {integer*times}");
                
            }
            if (multiplier > 10)
            {
                Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
            }

        }
    }
}
