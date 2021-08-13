using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\/=])([A-Z][A-Za-z]{2,})(\1)";
            Regex rg = new Regex(pattern);
            List<string> locations = new List<string>();
            string input = Console.ReadLine();
            MatchCollection destination = rg.Matches(input);

            int lenght = 0;

            foreach (Match item in destination)
            {
                locations.Add(item.Groups[2].Value);
                lenght += item.Groups[2].Value.Length;
            }
            Console.Write("Destinations: ");
            Console.WriteLine(String.Join(", ", locations));
            Console.WriteLine($"Travel Points: {lenght}");
        }
    }
}
