using System;
using System.Collections.Generic;
using System.Linq;

namespace Exodia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> biscuits = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "No More Money")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                string item = cmdArgs[1];

                if (command == "OutOfStock")
                {

                    string biscuit = cmdArgs[1];
                    while (biscuits.Exists(x=>x==biscuit))
                    {
                        int indexOfBiscuit = biscuits.IndexOf(biscuit);
                        biscuits[indexOfBiscuit] = "None";
                    }

                }

                else if (command == "Required")
                {
                    string word = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);

                    if (index>=0&&index<=biscuits.Count-1)
                    {
                        biscuits[index] = word;
                    }


                }
                else if (command == "Last")
                {

                    biscuits.Add(item);

                }
                input = Console.ReadLine();

            }

            var result = biscuits.Where(x => x != "None");
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
