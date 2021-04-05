using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int result = PrintVowels(input);
            Console.WriteLine(result);


        }
        public static int PrintVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'u' ||
                    currentChar == 'y' || currentChar == 'o')

                {
                    counter++;
                }
            }
            return counter;
        }
    }
   
}
