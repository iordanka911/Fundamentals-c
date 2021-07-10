using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperienceAmount = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());
            double sumExper = 0; 
            int countOfPlayedBattles = 0;
            for (int i = 1; i <= countOfBattles; i++)
            {
                countOfPlayedBattles++;
                double experienceEarnedPerBattle = double.Parse(Console.ReadLine());
                
                if (i % 3 == 0)
                {
                    experienceEarnedPerBattle = experienceEarnedPerBattle+ 0.15 * experienceEarnedPerBattle;
                }

                if (i%5==0)
                {

                    experienceEarnedPerBattle = experienceEarnedPerBattle - 0.10 * experienceEarnedPerBattle;
                }

                if (i%15==0)
                {
                    experienceEarnedPerBattle = experienceEarnedPerBattle + 0.05 * experienceEarnedPerBattle;
                }
               


                sumExper += experienceEarnedPerBattle;

                if (sumExper >= neededExperienceAmount)
                {

                    Console.WriteLine($"Player successfully collected his needed experience for {countOfPlayedBattles} battles.");
                    return;


                }



            }

            if (sumExper >= neededExperienceAmount)
            {

                Console.WriteLine($"Player successfully collected his needed experience for {countOfPlayedBattles} battles.");
                


            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperienceAmount - sumExper:f2} more needed.");
            }
            
            

        }
    }
}
