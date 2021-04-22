using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NUMBERS = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            int[] bombProp = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            int bomb = bombProp[0];
            int power= bombProp[1];

            for (int i = 0; i < NUMBERS.Count; i++)
            {
                int currentNumber = NUMBERS[i];
                if (currentNumber==bomb)
                {
                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex>NUMBERS.Count-1)
                    {
                        endIndex = NUMBERS.Count - 1;
                    }
                    int endIndexToRemove = endIndex - startIndex + 1;
                    NUMBERS.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }
            Console.WriteLine(NUMBERS.Sum());
        }
    }
}
