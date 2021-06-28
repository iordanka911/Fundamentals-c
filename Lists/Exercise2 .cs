using System;
using System.Collections.Generic;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //string[] names = new string[n];
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
                //names[i] = name;
               // Console.WriteLine(names[i]);
            }

            names.Remove("sto");

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
