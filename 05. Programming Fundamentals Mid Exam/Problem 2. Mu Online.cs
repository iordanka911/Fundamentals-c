using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeonsRooms = Console.ReadLine().Split('|');

            int health = 100;
            int bitcoins = 0;
            int count = 0;
            for (int i = 0; i < dungeonsRooms.Length - 1; i++)
            {
                count++;
                string[] splited = dungeonsRooms[i].Split();
                string split0 = splited[0];

                string split1 = splited[1];
                if (split0 == "potion")
                {
                    if (health < 100)
                    {
                        health += int.Parse(split1);//
                        int splait = int.Parse(split1);

                        if (health > 100)
                        {
                            splait = 100 - health;
                            health = 100;
                        }
                        Console.WriteLine($"You healed for {splait} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (split0 == "chest")
                {
                    bitcoins += int.Parse(split1);
                    Console.WriteLine($"You found {int.Parse(split1)} bitcoins.");
                }
                else
                {
                    int powerOfMonster = int.Parse(split1);

                    if (powerOfMonster >= 0 && powerOfMonster <= 100)
                    {
                        health -= powerOfMonster;
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {split0}.");
                        }
                        else if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {split0}.");
                            Console.WriteLine($"Best room: {count}");

                        }

                    }
                }

            }
            if (count == dungeonsRooms.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
