using System;

namespace beerKeg
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestVolume = 0;
            for (int i = 0; i < n; i++)
            {
                string currKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume>biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = currKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
