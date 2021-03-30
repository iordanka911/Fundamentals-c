using System;
using System.Linq;


namespace RectangleArea
{
    class Program
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(n);
            Console.WriteLine(result);
        }
       
        static int GetMultipleOfEvenAndOdds(int n)
        {
            int sumEven = GetSumOfEvenDigits(n);
            int sumOdd = GetSumOfOddDigits(n);
            return sumEven * sumOdd;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
