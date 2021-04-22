using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int maxLenght = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                maxLenght = Math.Max(maxLenght, PaliandromeLenght(letters, i, i));
            }
            for (int i = 0; i < letters.Length-1; i++)
            {
                maxLenght = Math.Max(maxLenght, PaliandromeLenght(letters, i, i + 1));
            }
            Console.WriteLine(maxLenght);
        }

        private static int PaliandromeLenght(string letters, int i1, int i2)
        {
           while (i1>=0&&i2<letters.Length&&letters[i1]==letters[i2])
            {
                i1--;
                i2++;
            }
            return i2 - i1 - 1;
        }
    }
}
