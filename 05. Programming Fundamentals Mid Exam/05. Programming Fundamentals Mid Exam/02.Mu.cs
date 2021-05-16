using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int initialHealth = 100;
            int initialBitcoins = 0;
            for (int i = 0; i <rooms.Length; i++)
            {
                string[] tokens = rooms[i].Split(" ");
                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                if ("potion" == command)
                {
                    int value = 0;
                    if (number + initialHealth <= 100)
                    {
                        value = number;
                       
                    }
                    else
                    {
                        value = 100 - initialHealth;
                        
                    }
                    initialHealth += value;
                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if ("chest" == command)
                {
                    initialBitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth-number>0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        break;
                    }
                }
            }
            if (initialHealth>0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }

        }
    }
}
