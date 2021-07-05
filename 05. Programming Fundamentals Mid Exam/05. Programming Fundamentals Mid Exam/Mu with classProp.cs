using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApp89
{
    class DungeonRuner
    {
        public int InitialHealth { get; set; }
        public int Coins { get; set; }

        public void Heal(int amount)
        {
            InitialHealth += amount;
            if (InitialHealth > 100)
            {
                amount -= InitialHealth - 100;
                InitialHealth = 100;
            }

            Console.WriteLine($"You healed for {amount} hp. ");
            Console.WriteLine($"Current health: {InitialHealth} hp.");
        }
        public void CollectChest(int amount)
        {
            Console.WriteLine($"You found {amount} bitcoins.");
            Coins += amount;
        }
        public bool AtackMomster(string monsterName, int amount, int room)
        {
            if (InitialHealth > amount)
            {
                Console.WriteLine($"You slayed {monsterName}.");
                InitialHealth -= amount;
                return false;
            }
            else
            {
                Console.WriteLine($"You died! Killed by {monsterName}.");
                Console.WriteLine($"Best room: {room}");
                return true;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            bool isDead = false;
            DungeonRuner runner = new DungeonRuner() { InitialHealth = 100, Coins = 0 };
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] splitted = rooms[i].Split((" "));
                string command = splitted[0];
                int amount = int.Parse(splitted[1]);

                if (command == "potion")
                {
                    runner.Heal(amount);
                }
                else if (command == "chest")
                {
                    runner.CollectChest(amount);
                }
                else
                {
                    if (runner.AtackMomster(command, amount, i + 1))
                    {
                        isDead = true;
                        break;
                    }
                       
                }

            }

            if (!isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {runner.Coins}");
                Console.WriteLine($"Health: {runner.InitialHealth}");
            }
        }
    }
}
