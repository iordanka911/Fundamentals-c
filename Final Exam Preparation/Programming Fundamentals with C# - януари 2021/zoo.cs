using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, int> animalFood = new Dictionary<string, int>();
            Dictionary<string, string> animalArea = new Dictionary<string, string>();

            while (command != "EndDay")
            {
                string[] cmd = command.Split(": ").ToArray();
                if (cmd[0] == "Add")
                {
                    string[] cmdAdd = cmd[1].Split("-");
                    string animalName = cmdAdd[0];
                    int neededFoodQuantity = int.Parse(cmdAdd[1]);
                    string area = cmdAdd[2];

                    if (!animalFood.ContainsKey(animalName))
                    {
                        animalFood.Add(animalName, neededFoodQuantity);
                        animalArea.Add(animalName, area);
                    }
                    else
                    {
                        animalFood[animalName] += neededFoodQuantity;
                    }
                }
                else if (cmd[0] == "Feed")
                {
                    string[] cmdFeed = cmd[1].Split("-");
                    string animalName = cmdFeed[0];
                    int food = int.Parse(cmdFeed[1]);
                    if (animalFood.ContainsKey(animalName))
                    {
                        animalFood[animalName] -= food;
                        if (animalFood[animalName] <= 0)
                        {
                            animalFood.Remove(animalName);
                            animalArea.Remove(animalName);
                            Console.WriteLine($"{animalName} was successfully fed");
                        }
                    }
                }
                command = Console.ReadLine();
            }
            //--
            animalFood = animalFood.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Animals:");
            foreach (var animal in animalFood)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            Dictionary<string, int> hungryAnimals = new Dictionary<string, int>();
            foreach (var animal in animalArea)
            {
                if (!hungryAnimals.ContainsKey(animal.Value))
                {
                    hungryAnimals.Add(animal.Value, 0);
                }
                hungryAnimals[animal.Value]++;
            }

            hungryAnimals = hungryAnimals.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var area in hungryAnimals)
            {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }
        }
    }
}
