using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reverseWord = null;
            for (int i = str.Length-1; i >=0; i--)
            {
                reverseWord += str[i];
            }
            Console.WriteLine(reverseWord);
        }
    }
}
