using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();

            string input = null;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                List<string> commandArgs = input.Split(" ").ToList();
                string command = commandArgs[0];

                switch (command)
                {
                    case "Loot":
                        string[] items = commandArgs.Skip(1).ToArray();
                        LootChest(items, chest);
                         break;
                    case "Drop":
                        int index = int.Parse(commandArgs[1]);
                        DropChest(index, chest);

                        break;
                    case "Steal":
                        int count = int.Parse(commandArgs[1]);
                        StealCount(count, chest);
                        break;
                    default:
                        break;
                }
            }
             double  average = GetAverageChest(chest);

            if (chest.Count!=0)
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            //Console.WriteLine(string.Join(" ", chest));
        }

        private static double GetAverageChest(List<string> chest)
        {
            double sum = 0;

            foreach (string item in chest)
            {
                sum += item.Length;
            }

            double average = sum / chest.Count;
            return average;
        }

        private static void StealCount(int count, List<string> chest)
        {
            int index = chest.Count - count;
            string[] deletedItems = null;
            
            if (index>=0)
            {
                deletedItems = chest.Skip(index).ToArray();
                chest.RemoveRange(index, count);
            }
            else
            {
                deletedItems = chest.ToArray();
                chest.Clear();
            }


            Console.WriteLine(string.Join(", ", deletedItems));
        }

        private static void DropChest(int index, List<string> chest)
        {
            if (IsValidIndex(index, chest))
            {
                string item = chest[index];
                chest.RemoveAt(index);
                chest.Add(item);
            }

        }

        private static bool IsValidIndex(int index, List<string> list)
        {
            return index < list.Count && index >= 0;
        }

        private static void LootChest(string[] items, List<string> chest)
        {
            foreach (string item in items)
            {
                if (!chest.Contains(item))
                {
                    chest.Insert(0, item);
                }
            }

        }
    }
}
