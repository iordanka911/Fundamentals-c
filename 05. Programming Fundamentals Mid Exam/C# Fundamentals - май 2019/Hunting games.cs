using System;

namespace theHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int countPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double water = days * countPlayers * waterPerDayPerPerson;
            double food = days * countPlayers * foodPerDayPerPerson;

            bool isBreaked = false;

            for (int i = 1; i <=days; i++)
            {
                double woodEnergy = double.Parse(Console.ReadLine());
                groupEnergy -= woodEnergy;
                if (groupEnergy<0)
                {
                    isBreaked = true;
                    break;
                }

                if (i%2==0)
                {
                    groupEnergy *= 1.05;
                    water *= 0.7;
                }

                if (i%3==0)
                {
                    food -= food / countPlayers;
                    groupEnergy *= 1.1;
                }
            }

            if (isBreaked)
            {
                Console.WriteLine($"You will run out of energy." +
                                  $"You will be left with {food:f2} food and {water:f2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You" +
                                  $"will be left with - {groupEnergy:f2} energy!");
            }
        }
    }
}
