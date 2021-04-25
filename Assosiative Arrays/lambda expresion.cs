using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(e =>
                        {
                            char first = e[0];

                            return new String(first, 10);
                        })
                        .ToArray();
            
        }
    }
}
