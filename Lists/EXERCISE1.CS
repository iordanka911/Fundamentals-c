using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             string values = Console.ReadLine();
             List<string> items = values.Split(' ').ToList();
             List<int> nums = new List<int>();
             for (int i = 0; i < items.Count; i++)
             {
                 nums.Add(int.Parse(items[i]));
             }
            */
            /*
            List<int> numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            */
            /*
            string values = Console.ReadLine();
            List<string> items = values.Split(' ').ToList();
            List<int> nums = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }
            */

            List<string> list = new List<string>() { 
            
                "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX" };

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("arr[{0}]={1}",index,list[index]);
            }

            List<string> list1 = new List<string>()
            {
                "one", "two", "three", "four", "five", "six"
            };
            Console.WriteLine(string.Join("; ",list1));

            

        }
    }
}
