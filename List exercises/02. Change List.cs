using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] cmdAgr = command.Split();
                string firstCommand = cmdAgr[0];
                int element = int.Parse(cmdAgr[1]);

                if (firstCommand=="Delete")
                {
                    listOfInt.RemoveAll(x=>x==element);
                }
                else if (firstCommand=="Insert")
                {
                    int position = int.Parse(cmdAgr[2]);
                    listOfInt.Insert(position, element);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",listOfInt));

         

        }
    }
}
