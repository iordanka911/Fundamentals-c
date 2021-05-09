using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> persons = new Dictionary<string, int>();
            persons.Add("Peter", 5);
            persons.Add("Ivan", 7);
            persons.Add("Ivan1", 6);

            

            foreach (var kvp in persons)
            {
                Console.WriteLine($"Hello my name is {kvp.Key} I am {kvp.Value} years old.");
            }

            Console.WriteLine(persons.ContainsKey("Stamat"));
        }
    }
}
