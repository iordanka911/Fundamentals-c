using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SumOfDigits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte numLines = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (numLines>0)
            {
                sum += char.Parse(Console.ReadLine());
                numLines --;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
