using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintInRange(firstChar, secondChar);
        }
        
        private static void PrintInRange(char firstChar, char secondChar)
        {
            if (firstChar>secondChar)
            {
                char first = firstChar;
                firstChar = secondChar;
                secondChar = first;
            }

            for (int i = firstChar+1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
   
}
