using System;

namespace beerKeg
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exaustFactor = int.Parse(Console.ReadLine());

            int count = 0;
            double tempPower = power * 0.5;

            while (power>=distance)
            {
                count++;
                power -= distance;

                if (power==tempPower&&exaustFactor!=0)
                {
                    power /= exaustFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
