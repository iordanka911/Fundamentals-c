using System;
using System.Linq;
using System.Collections.Generic;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string input;

            while ((input=Console.ReadLine()?.ToUpper())!="END")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

                if (index<0||index>=targets.Count)
                {
                    continue;
                }
                switch (command)
                {
                    case "SHOOT":
                        targets[index] -= value;
                        break;
                    case "ADD":

                        break;
                    case "STRIKE":

                        break;



                    default:
                        break;
                }
            }
        }
    }
}
