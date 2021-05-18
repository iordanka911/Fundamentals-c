using System;

namespace BiscuitFactory

{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBiscuits = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int otherFactory = int.Parse(Console.ReadLine());

            int totalCount = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i%3==0)
                {
                    if (amountOfBiscuits!=1)
                    {
                        totalCount += (int)(0.75 * amountOfBiscuits * countOfWorkers);
                    }
                  
                }
                else
                {
                    totalCount += amountOfBiscuits * countOfWorkers;
                }    
               
            }
            Console.WriteLine($"You have produced {totalCount} biscuits for the past month.");

            int difference = totalCount - otherFactory;
            decimal percent = difference / (decimal)otherFactory * 100;
            string sign = "more";
            if (percent<0)
            {
                percent *= -1;
                sign = "less";
            }
            Console.WriteLine($"You produce {percent:f2} percent {sign} biscuits.");
        }
    }
}
