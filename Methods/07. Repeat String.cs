using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            PrintString(text, num);
        }
        private static void PrintString(string str, int count)
        {
                string result = string.Empty;

                for (int i = 0; i < count; i++)
                {
                    result += str;
                }
            Console.WriteLine(result);
        }

        
    }
}
