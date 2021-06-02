using System;
using System.Linq;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Console.ReadLine()
                 .Select(x => int.Parse(x.ToString()))
                 .Sum();
            Console.WriteLine(sum);
        }
    }
}
