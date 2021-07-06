using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] commandArgs = input.Split(" ");

                string command = commandArgs[0];

                if (command=="Change")

                {
                    int currentNumber = int.Parse(commandArgs[1]);
                    int newNumber = int.Parse(commandArgs[2]);

                    if (numbers.Contains(currentNumber))
                    {
                        int index = numbers.IndexOf((currentNumber));

                        numbers[index] = newNumber;
                    }

                }
                else if (command=="Hide")
                {
                    int currentNumber = int.Parse(commandArgs[1]);
                    if (numbers.Contains(currentNumber))
                    {
                        numbers.Remove(currentNumber);
                    }

                }
                else if (command=="Switch")
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int seconNumber = int.Parse(commandArgs[2]);

                    if (numbers.Contains(firstNumber)&&numbers.Contains(seconNumber))
                    {
                        int firstIndex = numbers.IndexOf(firstNumber);
                        int secondIndex = numbers.IndexOf(seconNumber);

                        numbers[firstIndex] = seconNumber;
                        numbers[secondIndex] = firstNumber;
                    }
                }

                else if (command == "Insert")
                {
                    int index = int.Parse(commandArgs[1]) + 1;
                    int newNumber = int.Parse(commandArgs[2]);
                    if (index > -1 && index < numbers.Count)
                    {
                        numbers.Insert(index, newNumber);
                    }

                }

                else if (command=="Reverse")
                {
                    numbers.Reverse();
                }

                input = Console.ReadLine();
                
            }

            Console.WriteLine(string.Join(" ",  numbers));
        }
    }
}
