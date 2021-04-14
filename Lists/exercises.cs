using System;
using System.Collections.Generic;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.Add(number);

            }
           

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> { "Georgi", "Maria", "Petar" };
            myList.Reverse();
            myList.Sort();
            myList.Add("Ivan");
            myList.Remove("Maria");
            Console.WriteLine(myList.Count);
            Console.WriteLine(string.Join(" ", myList));
            

        }
    }
}
