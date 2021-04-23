using System;
using System.Collections.Generic;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> fruits = new SortedDictionary<string, double>()

            {
                { "orange",2.30}
            };

            fruits.Add("banana", 2.2);
            fruits.Add("apple", 0.90);

            foreach (var item in fruits)
            {
                Console.WriteLine($"The price of {item.Key} is {item.Value}");
            }
        }
    }
}
