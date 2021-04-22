using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp48
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
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0]?.ToUpper();
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);

              
                switch (command)
                {
                    case "SHOOT":
                        if (index < 0 || index >= targets.Count)
                        {
                            
                            continue;
                        }
                        else
                        {
                            targets[index] -= value;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }
                        

                        break;
                    case "ADD":
                        if (index < 0 || index >= targets.Count)
                        {
                            
                         Console.WriteLine("Invalid placement!");
                          
                        }
                        else
                        {
                            targets.Insert(index, value);
                        }
                        
                        break;
                    case "STRIKE":
                        if (index < 0 || index >= targets.Count)
                        {
                           
                           Console.WriteLine("Strike missed!");
                          
                            continue;
                        }
                        else
                        {
                            if (index - value < 0 || index + value >= targets.Count)
                            {
                                Console.WriteLine("Strike missed!");

                                continue;
                            }


                            targets.RemoveRange(index - value, (value * 2) + 1);
                            //for (int i = index - value; i <= index + value; i++)
                            {
                                targets.RemoveAt(index - value);
                            }
                        }
                       
                        break;

                    default: 
                        break;
                }
            }

            Console.WriteLine(string.Join('|',targets));
        }
    }
}
