using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();
            while (input!="Go Shopping!")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                string product = commandArgs[1];

                if (command=="Urgent")
                {
                    if (!groceries.Contains(product))
                    {
                        groceries.Insert(0,product);
                    }
                    

                }
                else if (command=="Unnecessary")
                {
                    if (groceries.Contains(product))
                    {
                        groceries.Remove(product);
                    }
                }

                else if (command == "Correct")
                {
                    string newItem = commandArgs[2];
                    if (groceries.Contains(product))
                    {
                        int index = groceries.FindIndex(x => x == product);
                        //groceries[index] = newItem;
                        groceries.RemoveAt(index);
                        groceries.Insert(index, newItem);
                    }
                }
                else if (command=="Rearrange")
                {
                    if (groceries.Contains(product))
                    {
                        groceries.Remove(product);
                        groceries.Add(product);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}


