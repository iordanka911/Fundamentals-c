using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            string[] words = { "abc", "def" };
            var result = words.Select(w => w + "x");

            Console.WriteLine(string.Join(' ',result));
            
        }
    }
}
