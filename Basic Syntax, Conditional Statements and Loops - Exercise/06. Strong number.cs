using System;

namespace strongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = input;
            int currentNumber = 0;
            int sumFactorial = 0;
            while (number!=0)
            {
                currentNumber = number % 10;//145%10=5
                number /= 10;

                int factorial = 1;

                for (int i = 1; i <=currentNumber; i++)
                {
                    factorial *= i;
                }
                sumFactorial += factorial;
            }
            string result = string.Empty;
            if (input == sumFactorial)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }
            Console.WriteLine(result);
            
        }
    }
}
