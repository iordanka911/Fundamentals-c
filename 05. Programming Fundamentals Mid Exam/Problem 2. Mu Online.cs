using System;

namespace _2_Zadacha_Izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] staii = Console.ReadLine().Split('|');

            int zdrave = 100;
            int bitkoins = 0;
            int count = 0;
            for (int i = 0; i < staii.Length - 1; i++)
            {
                int curenthell = 0;
                count++;
                string[] splited = staii[i].Split();
                string split0 = splited[0];

                string split1 = splited[1];
                if (split0 == "potion")
                {
                    if (zdrave < 100)
                    {
                        zdrave += int.Parse(split1);//
                        int splait = int.Parse(split1);

                        if (zdrave > 100)
                        {
                            splait = 100 - zdrave;
                            zdrave = 100;
                        }
                        Console.WriteLine($"You healed for {splait} hp.");
                        Console.WriteLine($"Current health: {zdrave} hp.");
                    }
                }
                else if (split0 == "chest")
                {
                    bitkoins += int.Parse(split1);
                    Console.WriteLine($"You found {int.Parse(split1)} bitcoins.");
                }
                else
                {
                    int silanaChudovishteto = int.Parse(split1);

                    if (silanaChudovishteto >= 0 && silanaChudovishteto <= 100)
                    {
                        zdrave -= silanaChudovishteto;
                        if (zdrave > 0)
                        {
                            Console.WriteLine($"You slayed {split0}.");
                        }
                        else if (zdrave <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {split0}.");
                            Console.WriteLine($"Best room: {count}");

                        }

                    }
                }

            }
            if (count == staii.Length)//-1
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitkoins}");
                Console.WriteLine($"Health: {zdrave}");
            }
        }
    }
}
