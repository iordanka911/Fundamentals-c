using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();
            bool isBigger = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currenyInt = arr[i];

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j]>=currenyInt)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currenyInt+" ");
                }

                isBigger = true;
            }
        }
    }
}
