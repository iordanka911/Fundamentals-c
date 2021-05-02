using System;
using System.Numerics;

namespace SnowBalls
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
             BigInteger highestValue = 0;
            int maxSnowballSnow = 0;
            int maxSnowballTme = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime= int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowBallValue>=highestValue)
                {
                    highestValue = snowBallValue;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballTme = snowballTime;
                    maxSnowballSnow = snowballSnow;
                    Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowBallValue} ({snowballQuality})");
                }
               
            }
           


        }
    }
}
