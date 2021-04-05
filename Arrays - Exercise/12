using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int counter = 0;
            int bestCount = 0;
            int bestbeginIndex = 0;
            int bestSum = 0;
            string bestSequence = "";
            string input = string.Empty;
            int bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0",
                    StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string bestSubSequence = "";
                counter++;

                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubSequence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestSubSequence);

                if (count > bestCount ||
                    (count == bestCount && beginIndex < bestbeginIndex) ||
                    (count == bestCount && beginIndex == bestbeginIndex && sum > bestSum || counter == 1))
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestbeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;

                }
            }
            char[] resul = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(" ", resul)}");
        }
    }
}
