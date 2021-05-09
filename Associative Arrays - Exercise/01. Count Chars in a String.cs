using System;
using System.Collections.Generic;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            foreach (var letter in input)
            {
                if (letter!=' ')
                {
                    if (!occurances.ContainsKey(letter))
                    {
                        occurances.Add(letter, 0);
                    }
                    
                     occurances[letter]++;
                                      
                }
            }

            foreach (var c in occurances)
            {
                char currentKey = c.Key;
                int currentValue = c.Value;

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}
