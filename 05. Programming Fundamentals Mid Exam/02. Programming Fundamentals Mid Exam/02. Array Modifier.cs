using System;
using System.Linq;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int index1 = 0;
                int index2 = 0;

                switch (tokens[0])
                {
                    case "swap":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);
                        int tempNumber = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = tempNumber;
                        break;
                    case "multiply":
                        index1 = int.Parse(tokens[1]);
                        index2 = int.Parse(tokens[2]);

                        numbers[index1] *= numbers[index2]; 
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
