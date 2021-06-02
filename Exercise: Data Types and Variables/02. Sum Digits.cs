using System;
using System.Collections.Generic;

namespace SumOfDigits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            do
            {
                sumOfDigits += n % 10;
                n = n / 10;
            }
            while (n > 0);
            
            /*  while (inputNumber>0)
            {
                sum += inputNumber % 10;
                inputNumber /= 10;
            }
            */
            Console.WriteLine(sumOfDigits);
        }
    }
}
