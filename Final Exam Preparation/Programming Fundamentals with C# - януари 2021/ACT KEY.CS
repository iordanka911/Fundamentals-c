using System;
using System.Collections.Generic;

namespace ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command!="Generate")
            {
                string[] tokens = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Contains":
                        if (activationKey.IndexOf(tokens[1])!=-1)
                        {
                            Console.WriteLine($"{activationKey} contains {tokens[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(tokens[2]);
                        int endIndex = int.Parse(tokens[3]);
                        string firstpart = activationKey.Substring(0, startIndex);
                        string secondPart = activationKey.Substring(startIndex, endIndex - startIndex);
                        string thirdPart = activationKey.Substring(endIndex);
                        if (tokens[1].ToUpper()=="UPPER")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }

                        activationKey = firstpart + secondPart + thirdPart;

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":

                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

        }
    }
}
