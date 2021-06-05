using System;

namespace ConsoleApp75
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;

                Console.WriteLine(array[i]);
            }
        }
    }
}
