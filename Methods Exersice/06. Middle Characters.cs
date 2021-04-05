using System;

namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            if (input.Length%2==0)
            {
                output = GetMiddleCharFromStringLeght(input);
            }
            else
            {
                output = GetMiddleCharFromOddLenght(input);
            }

            Console.WriteLine(output);
        }

        private static string GetMiddleCharFromOddLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromStringLeght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index-1, 2);
            return chars;
        }
    }
   
}
