using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int num = 1; num <= number; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
                String tf = "";
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                
                if (isSpecial)
                {
                    tf = "True";
                }
                else
                {
                    tf = "False";
                }
                Console.WriteLine($"{digits} -> {tf}");
                num = digits;
               

            }
        }
    }
}
